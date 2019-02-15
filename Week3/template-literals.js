/* let name = 'bob';
console.log(`hi ${name}`);

let sentence = `some text some text 
                 some text some text.`;
console.log(sentence); */


function getReasonCount() { return 2;}

let interpolation = `Give me ${(getReasonCount() == 1) ? 'one good reason': 'a few reasons'} to try this`;
console.log(interpolation);