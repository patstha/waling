function sayHello(name: string) {
    if (name && name.trim().length > 0) {
        console.info(`Hello, ${name}`);
    } else {
        console.info("Hello, world!");
    }
    //populateInputWalingPerson();
}

function sayGoodbye(name: string) {
    if (name && name.trim().length > 0) {
        console.info(`Goodbye, ${name}`);
    } else {
        console.info("Goodbye, cruel world!");
    }
}

function populateInputWalingPerson(selected: any) {
    const hiddenInputElement = document.getElementById("HiddenWalingPersons") as HTMLInputElement;
    const multiselectElement = document.getElementById("WalingPerson") as HTMLSelectElement;
    const options = multiselectElement.selectedOptions;
    const y = Array.from(options).map(({ value }) => value);
    console.info({ y });
    hiddenInputElement.value = y.join(';');
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

const multiselectElement = document.getElementById("WalingPerson") as HTMLSelectElement;
multiselectElement.addEventListener("selectionchange", (event) => {
    console.info("hello");
    const hiddenInputElement = document.getElementById("HiddenWalingPersons") as HTMLInputElement;
    const multiselectElement = document.getElementById("WalingPerson") as HTMLSelectElement;
    const options = multiselectElement.selectedOptions;
    const y = Array.from(options).map(({ value }) => value);
    console.info({ y });
    hiddenInputElement.value = y.join(';');
    debugger;
});