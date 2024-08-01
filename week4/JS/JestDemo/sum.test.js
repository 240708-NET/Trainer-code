const sum = require('./index.js');

test('add two numbers together', () => {
    expect(sum(5, 10)).toBe(15);
})