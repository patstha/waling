class Privacy {
    Respect(name: string): void {
        if (name.trim() === "") {
            name = "person";
        }
        alert(`Hello ${name}! We respect your privacy!`);
    }
}