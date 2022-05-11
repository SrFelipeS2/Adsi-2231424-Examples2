let saludo = process.env.NOMBRE || 'sin nombre';
let ciudad = process.env.CIUDAD || 'sin Ciudad';

console.log(`Hola ${saludo}`);
console.log(`Ciudad: ${ciudad}`);
