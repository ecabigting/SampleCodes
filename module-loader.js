// Sample Code from Node.js Design Patterns
// By Mario Casciaro & Luciano Mammino

function loadModule (filename,module,require) {
    const wrappedSrc = `(function (module,exports,require)){ ${fs.readFileSync(filename,'utf8')} })(module,module.export,require)`
    eval(wrappedSrc)
}

function require (moduleName) {
    console.log(`Require invoked for module: ${moduleName}`)
    // A module name is accepted as input, and the very first thing that we do is resolve the full path of the module, 
    // which we call id. This task is delegated to require.resolv
    const id = require.resolve(moduleName)
    // If the module has already been loaded in the past, it should be available in the cache. 
    // If this is the case, we just return it immediately.
    if(require.cache[id]) {
        return require.cache[id].exports
    }
    // Module Meta
    // If the module has never been loaded before, we set up the environment for the first load. 
    // In particular, we create a module object that contains an exports property initialized with an empty object literal. 
    // This object will be populated by the code of the module to export its public API.
    const module = {exports:{},id}
    // Update the cache
    // After the first load, the module object is cached.
    require.cache[id] = module
    // Load the module
    // The module source code is read from its file and the code is evaluated, as we saw before. 
    // We provide the module with the module object that we just created, and a reference to the require() function. 
    // The module exports its public API by manipulating or replacing the module.exports object.
    loadModule(id,module,require)
    return module.exports
}
require.cache = {}
require.resolve = (moduleName) => {}