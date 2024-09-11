USE libraryDB;
GO

-- 1. Tabla Books


INSERT INTO Books
VALUES 
    ('El Principito', 'Antoine de Saint-Exupéry', 1998),
    ('Romeo y Julieta', 'William Shakespeare', 1998),
    ('Cien años de soledad', 'Gabriel García Márquez', 1967),
    ('1984', 'George Orwell', 1949),
    ('Don Quijote de la Mancha', 'Miguel de Cervantes', 1605);
GO


SELECT * FROM Books;
GO


UPDATE Books
SET Title = 'El arte de la Guerra', Author = 'Sun Tzu'
WHERE BookID = 1;
GO


DELETE FROM Books 
WHERE BookID = 2;
GO

-- 2. Tabla Members

INSERT INTO Members
VALUES
    ('2023-09-11', 'Adonay Hernandez', 'Adonay@gmail.com'),
    ('2023-09-12', 'Beatriz Pérez', 'beatriz.perez@example.com'),
    ('2023-09-13', 'Carlos López', 'carlos.lopez@example.com'),
    ('2023-09-14', 'Diana Morales', 'diana.morales@example.com'),
    ('2023-09-15', 'Eduardo Fernández', 'eduardo.fernandez@example.com');
GO


SELECT * FROM Members;
GO


UPDATE Members 
SET  = 'Ernesto Ortiz' 
WHERE MemberID = 1;  
GO

GO
DELETE FROM Members
WHERE MemberID = 3;
GO

-- 3. Tabla Loans


INSERT INTO Loans
VALUES 
    ('2024-09-11', 1, 1),
    ('2024-09-12', 2, 2),
    ('2024-09-13', 3, 3),
    ('2024-09-14', 4, 4),
    ('2024-09-15', 5, 5);
GO

UPDATE Loans SET  BookID = 26 WHERE LoanID = 1
GO

SELECT * FROM Loans WHERE LoanID = 1
GO


