# Actividad_Principios_Solidos_Ardiles_Rocio

En mi ejercicio aplique la Responsabilidad Única de esta manera:
 - "ClickDetector" detecta los clics y "ClickCounter" los cuenta. (Si yo necesitara cambiar cómo se detectan o cómo se cuenta, modificaria solo esa parte sin romper lo demás)

Y la Inversión de Dependencias se aplica de esta manera:

- ClickDetector no esta atado a ClickCounter, sino a una interfaz llamada "IClickHandler", esto me permite cambiar el contador por otra cosa sin tocar el detector. Al conectar esas partes usando una interfaz para que no esten
atadas entre si, puedo cambiar una sin romper la otra.
