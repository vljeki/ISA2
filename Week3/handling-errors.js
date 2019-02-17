/* let a = 7 * undefined/ "panama";
console.log(a); */

/* function beforeTryCatch() {
    let obj =undefined;
    console.log(obj.b);
    console.log('If the previos line of code throws an exprection you\'ll never see this');
} */

//beforeTryCatch();

/* function afterTryCatch() {
    try {
        let obj =undefined;
        console.log(obj.b);
        console.log('If the previos line of code throws an exprection you\'ll never see this');
    } catch (error) {
        console.log('I caught an exception: ' + error.message);
    } finally {
        console.log('This will happen bo matter than');
    }
    
    console.log('My application is still running');
}
afterTryCatch(); */

function performCalculation(obj) {
    if (!obj.hasOwnProperty('b')) {
        throw new Error('Object missing property');
    }
    // continue with calculation w/ obj.b
    return 6;
}   

function performHigherLevelOperation() {
    let obj = {};
    let value = 0;
    try {
        value = performCalculation(obj);
    } catch (error) {
        console.log(error.message);
    }

    if (value == 0) {
        //contingency
        // retry logic
    }
}

performHigherLevelOperation();