var currScript=document.currentScript,entryScript=document.createElement("script");entryScript.async=!1,currScript.src.indexOf("?bustv2=")>=0||window.__igLibraryLoad?(window.__igEntryBundle=entryScript,window.__igSkipCacheBust?entryScript.src=currScript.src.replace(/app.bootstrap.js/,"app.0a801cfca3bcc17e8ce6.bundle.js"):entryScript.src=currScript.src.replace(/app\.bootstrap\.js\?bustv2=.*/,"app.0a801cfca3bcc17e8ce6.bundle.js"),currScript.after(entryScript)):(window.__igSkipCacheBust?entryScript.src=currScript.src.replace(/app.bootstrap.js/,"app.0a801cfca3bcc17e8ce6.bundle.js"):entryScript.src=currScript.src.replace(/app\.bootstrap\.js\?bust=.*/,"app.0a801cfca3bcc17e8ce6.bundle.js"),document.write(entryScript.outerHTML));