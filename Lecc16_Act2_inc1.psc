Algoritmo Lecc16_Act2_Inc1
	Dimensionar edadPersonas[7]
	Definir indice, cantidadMAyores Como Entero
	cantidadMAyores<-0
	Para indice<-1 Hasta 7 Con Paso paso Hacer
		Escribir "Ingrese la edad de la persona ",indice,":"
		Leer edadPersonas[indice]
		
		Si edadPersonas[indice] >= 18 Entonces
			cantidadMAyores<-cantidadMAyores+1
		FinSi
	Fin Para
	Escribir "Cantidad de Personas Mayores de edad: ",cantidadMAyores
FinAlgoritmo
