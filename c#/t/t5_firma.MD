**#LA FIRMA ELECTRÓNICA**

##DEFINICIÓN
La firma electrónica es un conjunto de datos electrónicos que asociados a un documento electrónico y cuyas funciones básicas son:
•	Identificar de forma inequívoca al firmante.
•	Asegurar la integridad del documento electrónico.
•	Asegurar el no repudio del documento electrónico.

##EL CERTIFICADO ELECTRÓNICO
Para firmar un documento electrónico es necesario disponer de un certificado digital o de un DNI electrónico.
El certificado electrónico es un documento expedido por una Autoridad de Certificación e identifica a una persona(física o jurídica) con un par de claves.
Tiene como función validar y certificar que una firma electrónica se corresponde con un persona o entidad concreta
Contiene la información necesaria para firmar electrónicamente e identificar a su propietario con sus datos: nombre, NIF, algoritmo y claves de firma, fecha de expedición y organismo que lo expide.
La autoridad de Certificación da fe de que la firma electrónica se corresponde con un usuario concreto.

##LAS CLAVES DIGITALES
En un certificado, las claves digitales son los elementos esenciales para la firma e identificación del firmante. Existen dos claves, la clave privada y la clave pública, y trabajan complementariamente. Lo que cifra o codifica una clave sólo puede descifrar o decodificar la otra.
La diferencia entre ellas es que la clave privada esta pensada para que nunca salga del certificado y este siempre bajo el control del firmante, en cambio la clave pública se puede repartir o enviar a otros usuarios.
En ocasiones se habla de certificado privado para referirse al certificado que contiene la clave pública y la privada y del Certificado público para referirse al certificado que sólo contiene la clave pública

##RENOVACIÓN DEL CERTIFICADO
Los certificados electrónicos tiene  un periodo de validez de 36 meses y se puede renovar dos meses antes.
Si el certificado caduca es necesario volver a realizar el proceso de solicitud, sin embargo si se realiza la renovación antes de que caduque no es necesaria la solicitud nueva.

##EL PROCESO BÁSICO DE FIRMA ELECTRÓNICA
Los pasos son los siguientes:
•	El usuario dispone de un documento electrónico y de un certificado digital que le pertenece y le identifica
•	La aplicación o dispositivo digital utilizados para la firma realiza un resumen del documento. El resumen de un documento de gran tamaño puede llegar a ser tan solo de unas pocas líneas. Cualquier modificación del documento implica también una modificación del resumen
•	La aplicación utiliza la clave privada para codificar el resumen
•	La aplicación crea otro documento electrónico que contiene ese resumen codificado, ese nuevo documento es la firma electrónica.
El resultado de todo este proceso es un documento electrónico obtenido a partir del documento original y de las claves del firmante, la firma electrónica, por tanto, es el mismo documento electrónico resultante.

##FORMATOS DE FIRMA
EL formato de la firma es la forma como se genera el documento de firma y como se guarda o estructura la información de firma en el documento generado.
Un fichero de firma tiene un formato que viene determinado por:
•	Estructura del fichero: formatos CadES, XadES, PadES, OOXML, ODF,…
Una firma electrónica es un fichero que contiene información sobre el documento original, el firmante, la fecha de la firma, algoritmos utilizados y posible caducidad de la firma.
La estructura de esta información viene determinada por distintos formatos:
◦	CadES(CMS Avanzado) es el primer formato de firma estandar. Apropiado para ficheros grandes, después de firmar la información se guarda en forma binaria
◦	XadES(XML Avanzado) el resultado es un fichero XML
◦	PadES(PDF Avanzado) es el más adecuado para documentos con formato PDF.
◦	OOXML y ODF se utilizan en Microsoft Office y Open Office
Autofirma permite configurar el formato a utilizar
•	Donde se guarda el documento originales
Podemos tener dos casos:
◦	el documento original se incluye en el fichero de firma
Ventaja: No es necesario guardar siempre el documento original y el documento de firma porque el primero esta incluido en el segundo
Desventaja: Si es tamaño del fichero e grande se usa más espacio de almacenamiento, porque al final se tiene el original por un lado y el que contiene la firma por otro.
En el caso de Cades las firmas se llaman firmas implícitas, es la más usada.
En Xades XML hablamos de firmas despegadas, envolventes y envueltas según en que sitio del propio fichero de firma se guarde el original.
◦	el documento no se incluye en la firma
El documento no se incluye en el resultado de firma o solamente se incluye una referncia al lugar en e l que se encuentra para que el documento pueda ser localizado. Se obtienen fichero de tamaño más reducido pero el documento original siempre hay que guardarlo junto a la firma
•	Firmas con múltiples usuarios
En papel un documento puede contener la firma de varias personas:
◦	en un caso las firmas pueden tener el mismo peso o valor legal, por lo que da igual el orden en el que se estampen la firmas en el documento
◦	Otro caso, es el que unas firmas sirven para refrendar o certificar otras firmas anteriores, por lo que el orden en el que se estampan las firmas es importante
EL equivalente a esas firmas son las firmas múltiples, pueden ser:
◦	Firmas simples, son la básicas, solo tienen un firmante
◦	Co-firma o firma en línea, es la firma múltiple en la que todos los firmantes están al mismo nivel y no importa el orden en el que se firma. Se suele usar en resultados de reuniones, conferencias, …
◦	Contra-firma o firma en cascada, firma múltiple en la que el orden en el que se firma es importante, ya que cada firma debe refrendar o certificar la firma del firmante anterior. La contra-firma se utiliza especialmente en aplicaciones como los Porta Firmas.
Autofirma permite los tres tipos de firma, el usuario puede configurar el tipo de firma múltiple que desea realizarse.
•	Longevidad de la firma
Para verificar una firma es necesario:
◦	comprobar la integridad de los datos firmados asegurando que estos no hayan sufrido ninguna modificación
◦	comprobar que el estado del certificado con el que se firmó era el correcto, es decir, era vigente en el momento de la operación
En el caso de la firma electrónica básica, si el certificado está caducado automáticamente se da la firma como no válida.
Para saber que el certificado estaba vigente cuando firmo los formatos AdES (Cades, Xades y Pades) contemplan la posibilidad de incorporar a las firmas electrónicas información adicional que garantiza la validez de una firma a lo largo de un plazo, una vez vencido el periodo de validez del certificado.
Estos formatos añaden a la firma evidencias de terceros(de autoridad de certificación) y certificaciones de tiempo, que realmente certifican cuál era el estado del certificado en el momento de la firma.
•	Sello de tiempo
El sellado de tiempo es un método para probar que un conjunto de datos existió antes de un momento dado y que ninguno de estos datos ha sido modificado desde entonces
El sello de tiempo es una firma de autoridad de sellado de tiempo(TSA) que actua como tercera parte de confianza testificando la existencia de dichos datos electronicos en una fecha y hora concretos.
El sellado de tiempo proporciona un valor añadido a la utilización de firma digital, ya que la firma por si sola no proporciona ninguna informacion acerca del momento de creación de la firma, y en el caso de que el firmante la incluyese, esta habria sido proporcionada por una de las partes, cuando lo recomendable es que la marca de tiempo sea proporcionada por una tercera parte de confianza.
◦	Resellado, puesto que el sello de tiepo es una firma realizada con el certificado electrónico de la autoridad de sellado, cuando ese certificado caduca, el sello  y por tanto la firma dejan de ser válidas. Por eso, antes de que el certificado de la TSA caduque es necesario resellar o aplicar de nuevo el sello temporal para mantener la validez temporal de la firma.

##LAS APLICACIONES DE FIRMA
Las aplicaciones de Firma son los programas que permiten firmar un documento electrónico.
Existen algunos programas, Adobe Acrobat, Microsoft Word, que permiten firmar el mismo documento que se genera, pero tiene dos inconvenientes:
•	No todos los programas que generan documentos son capaces también de firmarlos
•	El destinatario del documento firmado deberá tener la misma aplicación para ser capaz de verificar la firma
Las herramientas o aplicaciones especificas de firma electrónica son capaces de firmar cualquier tipo de documento electrónico y ayudar a superar los inconvenientes anteriores, Además se pueden descargar gratuitamente.
•	Autofirma, es una aplicación realizada por el Ministerio de Hacienda y Administraciones Públicas. Su principal objetivo es ofrecer al usuario un sistema de firma en el que este pueda firmar cualquier tipo de documento de manera sencilla. El usuario indica qué fichero quiere firmar y la aplicación escoge automáticamente el formato de firma que debe aplicar.
•	Valide (Aplicación de Validación de firma y certificados Online de @firma) es la plataforma e validación que la Administración General del Estado pone a disposición de las Administraciones y de los ciudadanos para la validación de certificados y, ofrece varios servicios como:
◦	Validación de firmas electrónicas
◦	Generación de firmas electrónicas en múltiples formatos
◦	Visualización de firmas con la ayuda del Visor.

##VISOR DE FIRMAS ELECTRÓNICAS
El visor es una herramienta que permite generar un informe de la firma y ver información de la propia firma electrónica y del documento firmado.
El documento que se genera no tiene el miso valor legal que la firma. De hecho puede ser válido en los términos que se determine para su uso. En general, en este caso, el documento impreso deberá contener un CSV o Código de Verificación que permite contrastar la copia impresa con la original electrónica.

##UTILIDAD PRÁCTICA TIENE LA FIRMA ELECTRÓNICA
Tiene muchas aplicaciones, como:
•	Realización de la Renta a través de Internet
•	Solicitudes en registros administrativos
•	Petición vida laboral
•	etc,...

##CÓMO VERIFICAR UN DOCUMENTO FIRMADO
La validación de una firma electrónica es el proceso por el que se comprueba:
•	La identidad del firmante
•	La integridad del documento firmado
•	La validez temporal del certificado utilizado
El proceso de validación de la firma no puede separarse del proceso de validación del certificado usado para la firma, y por eso la validación de la firma implica también la validación del certificado
El certificado electrónico solamente se puede validar mientras este activo, una vez caducado no se puede comprobar su estado. Si el certificado no es válido, esta caducado o revocado, la firma no puede ser validada correctamente
Necesitamos una conexión a internet para acceder a la plataforma de validación de certificados.



