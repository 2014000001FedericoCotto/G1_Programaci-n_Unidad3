Algoritmo Lecc16_act3_inc1
	Dimensionar numerosenteros[15]
	definir indice, comparador Como Entero
	Definir existerepetido Como Logico
	existerepetido<-Falso
	Para indice <- 1 hasta 15 Hacer
		Escribir "Ingrese el numero ",indice,":"
		Leer numerosenteros[indice]
		
	FinPara
	Para indice<- 1 Hasta 14 Hacer
		Para comparador<-indice+1 Hasta 15 Hacer
			Si numerosenteros[indice]=numerosenteros[comparador] Entonces
				existerepetido<-Verdadero
			Fin Si
			
		FinPara
	FinPara
	Si existerepetido Entonces
		Escribir "Si existe al menos un numero repetido"
	SiNo
		Escribir "No existe ningun numero repetido."
	Fin Si
	
FinAlgoritmo
	
