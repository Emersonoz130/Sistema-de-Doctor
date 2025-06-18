create database dbHospital;
--Creando las tablas : Tabla Doctor Verificar siempre cuales son las tablas 
--Principales
CREATE TABLE Doctores (
        Id_Doctor INT PRIMARY KEY IDENTITY(1,1),
        Nombre NVARCHAR(100) NOT NULL,
        Apellido NVARCHAR(100) NOT NULL,
        Especialidad NVARCHAR(100) NOT NULL,
        Cargo NVARCHAR(100) NOT NULL
    );
	--Tabla Pacientes
	 CREATE TABLE Pacientes (
        Id_Paciente INT PRIMARY KEY IDENTITY(1,1),
        Num_ISSS NVARCHAR(20) NOT NULL UNIQUE,
        Nombre NVARCHAR(100) NOT NULL,
        Apellido NVARCHAR(100) NOT NULL,
        Domicilio NVARCHAR(200) NOT NULL,
        Telefono NVARCHAR(20) NOT NULL,
        Sexo NVARCHAR(10) NOT NULL CHECK (Sexo IN ('Masculino', 'Femenino', 'Otro')),
        Costo_Tratamiento DECIMAL(10,2) NOT NULL DEFAULT 0.00
    );
	--Tabla Ingresos 
	CREATE TABLE Ingresos (
        Id_Ingreso INT PRIMARY KEY IDENTITY(1,1),
        Id_Paciente INT NOT NULL,
        Fecha_Ingreso DATETIME NOT NULL DEFAULT GETDATE(),
        Id_Doctor INT NOT NULL,
        Diagnostico NVARCHAR(MAX) NOT NULL,
        CONSTRAINT FK_Ingresos_Pacientes FOREIGN KEY (Id_Paciente) REFERENCES Pacientes(Id_Paciente),
        CONSTRAINT FK_Ingresos_Doctores FOREIGN KEY (Id_Doctor) REFERENCES Doctores(Id_Doctor)
    );

	--Llenaremos nuestras base con datos 
	--Probando el metodo de select para traer todos los datos
	 -- Insertar datos iniciales de doctores
    INSERT INTO Doctores (Nombre, Apellido, Especialidad, Cargo)
    VALUES 
    ('Juan Carlos', 'Mendoza', 'Cardiolog�a', 'Jefe de Cardiolog�a'),
    ('Mar�a Elena', 'Garc�a', 'Pediatr�a', 'Pediatra Senior'),
    ('Roberto Antonio', 'Hern�ndez', 'Neurolog�a', 'Neur�logo'),
    ('Laura Patricia', 'S�nchez', 'Ginecolog�a', 'Ginec�loga'),
    ('Carlos Eduardo', 'L�pez', 'Traumatolog�a', 'Cirujano Ortop�dico'),
    ('Ana Isabel', 'Rodr�guez', 'Dermatolog�a', 'Dermat�loga'),
    ('Jos� Manuel', 'P�rez', 'Oftalmolog�a', 'Oftalm�logo'),
    ('Sof�a Alejandra', 'Mart�nez', 'Psiquiatr�a', 'Psiquiatra');


	-- Insertar datos iniciales de pacientes
    INSERT INTO Pacientes (Num_ISSS, Nombre, Apellido, Domicilio, Telefono, Sexo, Costo_Tratamiento)
    VALUES 
    ('987654321', 'Ana Mar�a', 'G�mez', 'Calle Principal 123, Col. Centro', '5555-1234', 'Femenino', 1500.00),
    ('123456789', 'Luis Fernando', 'Rodr�guez', 'Avenida Central 456, Col. Moderna', '5555-5678', 'Masculino', 2300.50),
    ('456789123', 'Carlos Alberto', 'V�zquez', 'Boulevard Norte 789, Col. Jardines', '5555-9012', 'Masculino', 1800.75),
    ('789123456', 'Sof�a Guadalupe', 'D�az', 'Calle Sur 321, Col. Las Flores', '5555-3456', 'Femenino', 2100.00),
    ('321654987', 'Pedro Pablo', 'Ram�rez', 'Avenida Este 654, Col. Bosques', '5555-7890', 'Masculino', 1950.25);

	-- Insertar datos iniciales de ingresos
    INSERT INTO Ingresos (Id_Paciente, Fecha_Ingreso, Id_Doctor, Diagnostico)
    VALUES 
    (1, '2023-05-15 10:30:00', 1, 'Dolor tor�cico agudo, posible angina de pecho'),
    (2, '2023-05-16 14:15:00', 2, 'Control pedi�trico rutinario, vacunaci�n'),
    (3, '2023-05-17 09:45:00', 3, 'Cefalea cr�nica, evaluaci�n neurol�gica'),
    (4, '2023-05-18 11:20:00', 4, 'Control ginecol�gico anual'),
    (1, '2023-05-19 16:30:00', 5, 'Fractura de radio, requiere intervenci�n quir�rgica'),
    (5, '2023-05-20 08:15:00', 6, 'Dermatitis at�pica, tratamiento prescrito'),
    (2, '2023-05-21 13:00:00', 7, 'Evaluaci�n oftalmol�gica, miop�a progresiva'),
    (3, '2023-05-22 10:45:00', 8, 'Evaluaci�n psiqui�trica, seguimiento depresi�n');
	select * from Doctores;