let map = new Map();
map.set(1, 100);
map.set(2, 200);
map.set(3, 300);

const print = () => {
    for (const item of map) {
        // key   = item[0]
        // value = item[1]
        console.log(item[0] + ' - ' + item[1]); 
    }
};

console.log('map');
print();
console.log('map.has(4): ' + map.has(4)); // false
console.log('map.has(3): ' + map.has(3)); // true
console.log('map after map.delete(2)');
map.delete(2);
print();

