----    INNER JOIN    ----
-- Este permite obtener los registros que se encuentren en la union de dos tablas
-- es decir lo que pertenece a ambas tablas, lo que no queda excluido--

-- 1.- OBTENER EL TITULO DE TODOS LOS LIBROS Y EL NOMBRE COMPLETO DE SU AUTOR
SELECT TITULO, CONCAT (NOMBRE, " ", APELLIDO) AS "NOMBRE DEL AUTOR" FROM TBLIBRO
INNER JOIN TBAUTOR
ON TBLIBRO.IDAUTOR = tbautor.idAutor

-- 2.- CAMPOS REPETIDOS EN AMBAS TABLAS
SELECT TITULO, CONCAT (NOMBRE, " ", APELLIDO) AS "NOMBRE DEL AUTOR", TBLIBRO.FECHACREACION FROM TBLIBRO
INNER JOIN TBAUTOR
ON TBLIBRO.IDAUTOR = tbautor.idAutor

-- Buena practica, cuando se trabaja con varias tablas para distinguir de cual son los campos
-- se antecede al campo el nombre de la tabla

-- 3.- Se puede utilizar alias de las tablas, si su nombre es muy largo
SELECT TITULO, CONCAT (NOMBRE, " ", APELLIDO) AS "NOMBRE DEL AUTOR", A.FECHACREACION FROM TBLIBRO
INNER JOIN TBAUTOR AS A
ON A.IDAUTOR = tbautor.idAutor
----    USING    ----
-- Cuando las llaves primarias y foraneas llevan el mismo nombre, es posible sustituir
-- la clausa ON por USING, para realizar la comparacion
-- 4.- SUSTITUIR ON POR USING
SELECT TITULO, CONCAT (NOMBRE, " ", APELLIDO) AS "NOMBRE DEL AUTOR", TBLIBRO.FECHACREACION FROM TBLIBRO
INNER JOIN TBAUTOR
USING (IDAUTOR)
-- USING NO DEJA HACER CONDICIONES POR LO QUE ES NECESARIO REGRESAR AL ON
-- 5.- OBTENER LOS LIBROS QUE SUS AUTORES TENGAN SEUDONIMO
SELECT TITULO, CONCAT (NOMBRE, " ", APELLIDO) AS "NOMBRE DEL AUTOR", TBLIBRO.FECHACREACION FROM TBLIBRO
INNER JOIN TBAUTOR ON TBLIBRO.IDAUTOR=TBAUTOR.IDAUTOR
AND SEUDONIMO IS NOT NULL

----    LEFT JOIN = LEFT OUTER JOIN    ----
-- MUESTRA LA INTERSECCION Y  CONTENIDO DE LA TABLA EN PRIMERA POSICION O PRINCIPAL
-- EN ESTE CASO TBUSUARIO
-- La tabla tbLibro-tbUsuario nos permite ver que usuario presto que libro y en que fecha --
-- 6.- OBTENER EL NOMBRE COMPLETO DE LOS USUARIOS Y EL ID DE LOS LIBROS QUE PRESTO
SELECT
  CONCAT(nombre, " ", apellido),
  tblibro_tbusuario.idLibro
FROM tbusuario
LEFT JOIN tblibro_tbusuario ON tbusuario.idusuario = tblibro_tbusuario.idusuario
-- APARECEN TAMBIEN LOS USUARIOS QUE NO HAN PRESTADO LIBROS (ESTA EN LA TABLA A NO EN LA INTERSECCION)

-- 7.- OBTENER EL NOMBRE COMPLETO DE LOS USUARIOS Y EL ID DE LOS LIBROS QUE PRESTO (SOLO LOS QUE HAN HECHO PRESTAMOS)
SELECT
  CONCAT(nombre, " ", apellido),
  tblibro_tbusuario.idLibro
FROM tbusuario
LEFT JOIN tblibro_tbusuario ON tbusuario.idusuario = tblibro_tbusuario.idusuario
WHERE TBLIBRO_TBUSUARIO.IDLIBRO IS NOT NULL

-- 8.- USUARIOS QUE NO HAN PRESTADO LIBROS
SELECT
  CONCAT(nombre, " ", apellido),
  tblibro_tbusuario.idLibro
FROM tbusuario
LEFT JOIN tblibro_tbusuario ON tbusuario.idusuario = tblibro_tbusuario.idusuario
WHERE TBLIBRO_TBUSUARIO.IDLIBRO IS NULL

----    RIGHT JOIN = RIGHT OUTER JOIN    ----
-- MUESTRA LA INTERSECCION Y  CONTENIDO DE LA TABLA EN SEGUNDA POSICION
-- 9.- OBTENER EL NOMBRE COMPLETO DE LOS USUARIOS Y EL ID DE LOS LIBROS QUE PRESTO
SELECT
  CONCAT(nombre, " ", apellido),
  tblibro_tbusuario.idLibro
FROM tblibro_tbusuario
RIGHT JOIN tbusuario ON tbusuario.idusuario = tblibro_tbusuario.idusuario

----    MULTIPLES JOINS    ----
-- CONSULTA O UNION DE MUCHAS TABLAS A TRAVES DE TODOS LOS JOINS
-- 10.- OBTENER EL NOMBRE DEL USUARIO QUE HAYAN PRESTADO EL DIA DE HOY UN LIBRO 
SELECT DISTINCT -- para que no se repitan los usuarios
  CONCAT(tbusuario.nombre, " ", tbusuario.apellido) AS "NOMBRE USUARIO"
FROM tbusuario
INNER JOIN tblibro_tbusuario ON tbusuario.idusuario = tblibro_tbusuario.idusuario 
                          AND DATE(tblibro_tbusuario.fechaCreacion) = CURDATE() -- prestado hoy
INNER JOIN tblibro ON tblibro_tbusuario.idlibro = tblibro.idlibro -- fecha de prestamo

-- 11.- OBTENER EL NOMBRE DEL USUARIO QUE HAYAN PRESTADO EL DIA DE HOY UN LIBRO ESCRITO POR UN AUTOR CON SEUDONIMO
SELECT DISTINCT -- para que no se repitan los usuarios
  CONCAT(tbusuario.nombre, " ", tbusuario.apellido) AS "NOMBRE USUARIO"
FROM tbusuario
INNER JOIN tblibro_tbusuario ON tbusuario.idusuario = tblibro_tbusuario.idusuario 
                          AND DATE(tblibro_tbusuario.fechaCreacion) = CURDATE() 
INNER JOIN tblibro ON tblibro_tbusuario.idlibro = tblibro.idlibro 
INNER JOIN tbautor ON tblibro.idautor = tbautor.idautor AND tbautor.seudonimo IS NOT NULL; -- el autor tiene seudonimo

-- 12.- OBTENER EL NOMBRE DEL USUARIO Y LOS LIBROS CON SU NOMBRE DE AUTOR QUE HA PRESTADO
SELECT tbusuario.idUsuario, CONCAT(tbusuario.nombre, " ", tbusuario.apellido) AS "NOMBRE DEL USUARIO", tblibro.idLibro, titulo,CONCAT(tbautor.nombre, " ", tbautor.apellido) AS "NOMBRE DEL AUTOR" 
FROM tbusuario
INNER JOIN tblibro_tbusuario ON tbusuario.idusuario = tblibro_tbusuario.idusuario 
INNER JOIN tblibro ON tblibro_tbusuario.idlibro = tblibro.idlibro 
INNER JOIN tbautor ON tblibro.idAutor=tbautor.idAutor
