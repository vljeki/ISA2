/* var car = {
    make: "bmw",
    model: "745li",
    year: 2010, 
    getPrice: function() {
        //perform some calculations
        return 5000;
    },
    printDescription: function() {
        console.log(this.make + ' ' + this.model);
    }
}
car.printDescription(); */

/* function first() {
    return this;
}

console.log(first() === global);
 */
// this is Node's global object 
// because that's where the first method was called

/* function second() {
    'use strict';

    return this;
}

console.log(second() === global);
console.log(second() === undefined); */

// An object can be passed as the first argument to call or apply and this will be bound to it. 
/* let myObject = { value: 'My Object'};

// value is set on the global object
global.value = 'Global object';

function third(name) {
    // returns something different depending on how we call this method: 
    return this.value + name;
}

console.log(third());

//Both call and apply allow you to explicitly set what you want to represent 'this'.
//The difference is in how additional arguments to the function are sent. 
console.log(third.call(myObject), 'bob');
console.log(third.apply(myObject), ['bob']); */

function fifth() {
    console.log(this.firstName + ' ' + this.lastName);
}

let customer1 = {
    firstName: 'bob',
    lastName: 'tabor',
    print: fifth
}

let customer2 = {
    firstName: 'vlad',
    lastName: 'jek',
    print: fifth
}

customer1.print();
customer2.print();