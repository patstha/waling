function sayHello(name: string) {
    if (name && name.trim().length > 0) {
        console.info(`Hello, {name}`);
    } else {
        console.info("Hello, world!");
    }
}

sayHello("test")