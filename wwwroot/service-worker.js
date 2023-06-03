﻿// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
console.log("Entered wrong service-worker");
self.addEventListener('fetch', () => { });


