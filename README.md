## Título: Ciber Cafe
*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)
___
## Sobre mí: 
Soy recursante de la materia y los conceptos del la primera parte del cuatrimestre los tengo muy entendidos, actualmente conseguí mi primer trabajo
y es por eso que el parcial esta incompleto pero traté de hacer lo mas que pude. 
No fue dificil pensar en como encarar el parcial pero me iba complicando
yo solo todo el tiempo hasta el punto de no llegar a terminarlo. Hubieron puntos en los que me hubiese gustado utilizar conceptos de la segunda parte de la cursada
para que el codigo se haga mas corto pero no los use y el codigo quedó bastante extenso. Fue facil? en mi cabeza si, pero a la hora de porgramar me llevo mas tiempo
del que en realidad le dedique.
___
## Resumen
La aplicacion trataba de ser una imitacion a un software que una vez vi en ciber, donde el operario con un solo click puede autorizar el uso de un servicio
y al mismo tiempo ver el estado de sus servicios de una forma simple.
*gris: libre para ser usado
*rojo: en uso
*verde: tiempo en pausa y hora de cobrar viendo los datos de la "consola" (data grid)
El operario tiene la posibilidad de agregar usuarios rellenando un form que se adapta al servicio que quiera el cliente.
Y por ultimo un boton de estadisticas donde podria ver una "consola" con las estadisticas que seleccionara mediante botones
___
## Diagrama de clases
[Diagrama de clases](https://1drv.ms/u/s!AssK8mGpcoidjGmZYakbnwWau1Jy?e=u0iAGV)
___
## Justificación técnica
Métodos estáticos: todo la clase "CiberCafe" es una clase estatica donde sera la que maneje la informacion de la aplicacion
Sobrecarga: lo usé en los casos de querer reutilizar una misma firma pero con distintos parametros como en el caso de "Computadora.Mostrar"
Windows Forms: los tres forms
Colecciones: se utilizaron en list para almacenar las computadoras por un lado y las cabinas del Ciber Cafe. Tambien use Queue a la hora de simular las filas de los clientes segun su servicio
Encapsulamiento: lo use a la hora de separ los conceptos de dos servicios "Coputadoras" y "Telefonos" donde si bien puede hacer ciertas cosas igual, su logica es distinta
Herencia: al tener dos servicios distintos pero al final de todo servicios cree una clase abstracta que sera heredad por "Coputadoras" y "Telefonos" que podran usar la logica que contenga todos los sevicios
Polimorfismo: aplique polimorfismo al declarar funciones abstractas en "servicios" donde dependiendo quien la herede la funcionalidad va a ser diferente
___
## Propuesta de valor agregado
___