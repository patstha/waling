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


sayHello("Windows 10")
sayGoodbye("Windows 10")

function onSubmitPoll() {
    const poll = document.getElementById("poll");
    const favoriteCheese = document.getElementById('favorite-cheese');
    console.info({ poll });
    console.info({ favoriteCheese });
    debugger;
    alert("Congratulation, you have submitted the poll!");

}