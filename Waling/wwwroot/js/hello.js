function sayHello(name) {
    if (name && name.trim().length > 0) {
        console.info(`Hello, {name}`);
    }
    else {
        console.info("Hello, world!");
    }
}
function sayGoodbye(name) {
    if (name && name.trim().length > 0) {
        console.info(`Goodbye, {name}`);
    }
    else {
        console.info("Goodbye, cruel world!");
    }
}
sayHello("test");
//# sourceMappingURL=hello.js.map