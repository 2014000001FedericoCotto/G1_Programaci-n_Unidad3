Algoritmo Lecc16_act2_inc2
	Dimensionar numerosenteros[8]
	definir infice, numeroMAyor,Posicionmayor Como Entero
	Para infice <- 1 Hasta 8 Hacer
		Escribir "Ingrese el número ",infice,":"
		Leer numerosenteros[infice]
		Si infice=1 Entonces
			numeroMAyor<-numerosenteros[infice]
			Posicionmayor<-infice
		SiNo
			Si numerosenteros[infice]>numeroMAyor Entonces
				numeroMAyor<- numerosenteros[infice]
				Posicionmayor<- infice
			FinSi
			
		Fin Si
	FinPara
	
	Escribir "El numeroMAyor es:",numeroMAyor
	Escribir "Se encuentra en la posicion: ",Posicionmayor
FinAlgoritmo
	
