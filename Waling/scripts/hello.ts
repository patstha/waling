function sayHello(name: string) {
    if (name && name.trim().length > 0) {
        console.info(`Hello, ${name}`);
    } else {
        console.info("Hello, world!");
    }
}

function sayGoodbye(name: string) {
    if (name && name.trim().length > 0) {
        console.info(`Goodbye, ${name}`);
    } else {
        console.info("Goodbye, cruel world!");
    }
}


sayHello("qa guy")
sayGoodbye("qa guy")