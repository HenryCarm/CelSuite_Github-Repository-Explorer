import { readFileSync, writeFileSync, mkdirSync } from "node:fs";
import { minify } from "html-minifier-terser";
import JavaScriptObfuscator from "javascript-obfuscator";
const src = readFileSync(process.argv[2], "utf8");
const m = src.match(/<script>([\s\S]*?)<\/script>\s*<\/body>/);
if (!m) { console.error("no script block"); process.exit(1); }
const obf = JavaScriptObfuscator.obfuscate(m[1], {
  compact: true, controlFlowFlattening: true, controlFlowFlatteningThreshold: 0.4,
  stringArray: true, stringArrayThreshold: 0.75, stringArrayEncoding: ["base64"],
  stringArrayShuffle: true, splitStrings: true, splitStringsChunkLength: 24,
  selfDefending: false, renameGlobals: true, seed: 269263
}).getObfuscatedCode();
let out = src.replace(m[1], () => obf);
out = await minify(out, { collapseWhitespace: true, removeComments: true, minifyCSS: true });
mkdirSync("dist", { recursive: true });
writeFileSync("dist/index.html", out);
console.log("obfuscated bytes:", out.length);
