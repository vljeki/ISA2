let counter = (function () {
    let counter = 0;

    function print(message) {
        console.log(`${message} => ${count}`);
    }

    function getCount() {return count; }

    function setCount(value) { count = value; }

    function incrementCount() {
        count += 1;
        print('After increment: ');
    }

    function resetCount() {
        print('Before reset: ');
        count = 0;
        print('After reset: ');
    }

    return {
        get: getCount,
        set: setCount,
        increment: incrementCount,
        reset: resetCount
    }
})();