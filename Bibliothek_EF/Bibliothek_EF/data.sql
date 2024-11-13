INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (1, 'Karl', 'Marx', '1818-05-05');  -- Author: Karl Marx

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (2, 'George', 'Orwell', '1903-06-25');  -- Author: George Orwell

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (3, 'John', 'Doe', '1980-01-01');  -- Author: John Doe

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (4, 'Walter', 'Isaacson', '1952-05-20');  -- Author: Walter Isaacson

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (5, 'Andy', 'Weir', '1972-06-16');  -- Author: Andy Weir

-- CUSTOMERS
INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (6, 'Alice', 'Johnson', '1990-03-12');  -- Customer: Alice Johnson

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (7, 'Bob', 'Smith', '1985-07-25');  -- Customer: Bob Smith

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (8, 'Carol', 'Davis', '1992-10-15');  -- Customer: Carol Davis

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (9, 'David', 'Wilson', '1988-12-02');  -- Customer: David Wilson

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (10, 'Eve', 'Taylor', '1995-06-08');  -- Customer: Eve Taylor

-- LIBRARIANS
INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (11, 'Fay', 'Moore', '1983-01-20');  -- Librarian: Fay Moore

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (12, 'Grace', 'Clark', '1977-04-02');  -- Librarian: Grace Clark

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (13, 'Hank', 'Miller', '1980-09-17');  -- Librarian: Hank Miller

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (14, 'Ivy', 'Lewis', '1993-08-25');  -- Librarian: Ivy Lewis

INSERT INTO PERSONS (ID, FIRSTNAME, LASTNAME, DATEOFBIRTH)
VALUES (15, 'Jack', 'Walker', '1987-11-14');  -- Librarian: Jack Walker

-- Now insert into AUTHORS table (linked by AuthorId)
INSERT INTO AUTHORS (ID, Biography)
VALUES (1, 'Philosopher, economist, and political theorist.');  

INSERT INTO AUTHORS (ID, Biography)
VALUES (2, 'British novelist, essayist, and critic.');

INSERT INTO AUTHORS (ID, Biography)
VALUES (3, 'Experienced programmer and author of programming textBOOKS.'); 

INSERT INTO AUTHORS (ID, Biography)
VALUES (4, 'Biographer and historian.');

INSERT INTO AUTHORS (ID, Biography)
VALUES (5, 'Science fiction author known for his work "The Martian".');

INSERT INTO AUTHORS (ID, Biography)
VALUES (6, 'British author known for the Harry Potter 
series.');

INSERT INTO AUTHORS (ID, Biography)
VALUES (7, 'Author of detective novels, creator of 
Sherlock Holmes.');

INSERT INTO Books (Id, Title, ISBN, PublishedDate, BookType, AuthorId)
VALUES (1, 'Das Kapital', '978-3-16-148410-0', '1867-09-14', 'NonFiction', 1);
-- Bücher von George Orwell
INSERT INTO Books (Id, Title, ISBN, PublishedDate, BookType, AuthorId)
VALUES (2, '1984', '978-0-452-28423-4', '1949-06-08', 'Novel', 2);
-- Bücher von John Doe
INSERT INTO Books (Id, Title, ISBN, PublishedDate, BookType, AuthorId)
VALUES (3, 'Einführung in die Programmierung', '978-3-16-148410-1', '2020-01-01',
        'Textbook', 3);
-- Bücher von Walter Isaacson
INSERT INTO Books (Id, Title, ISBN, PublishedDate, BookType, AuthorId)
VALUES (4, 'Die Biografie von Albert Einstein', '978-1-59420-193-0', '2007-10-02',
        'Biography', 4);
-- Bücher von Andy Weir
INSERT INTO Books (Id, Title, ISBN, PublishedDate, BookType, AuthorId)
VALUES (5, 'Der Marsianer', '978-3-446-23559-6', '2011-02-11', 'ScienceFiction',
        5);
-- Bücher von J.K. Rowling
INSERT INTO Books (Id, Title, ISBN, PublishedDate, BookType, AuthorId)
VALUES (6, 'Harry Potter und der Stein der Weisen', '978-3-7459-9406-7', '1997-06-
26', 'Fantasy', 6);
-- Bücher von Arthur Conan Doyle
INSERT INTO Books (Id, Title, ISBN, PublishedDate, BookType, AuthorId)
VALUES (7, 'Der Hund von Baskerville', '978-3-16-148410-8', '1902-04-01',
        'Mystery', 7);

-- Insert CUSTOMERS (linked to PERSONS by ID)
INSERT INTO CUSTOMERS (ID, MembershipDate) VALUES (6, '2020-05-01');  -- Customer: Alice Johnson
INSERT INTO CUSTOMERS (ID, MembershipDate) VALUES (7, '2021-08-15');  -- Customer: Bob Smith
INSERT INTO CUSTOMERS (ID, MembershipDate) VALUES (8, '2019-11-10');  -- Customer: Carol Davis
INSERT INTO CUSTOMERS (ID, MembershipDate) VALUES (9, '2022-01-18');  -- Customer: David Wilson
INSERT INTO CUSTOMERS (ID, MembershipDate) VALUES (10, '2023-03-25');  -- Customer: Eve Taylor

-- Insert LIBRARIANS (linked to PERSONS by ID)
INSERT INTO LIBRARIANS (ID, EmployeeId) VALUES (11, 'LIB001');  -- Librarian: Fay Moore
INSERT INTO LIBRARIANS (ID, EmployeeId) VALUES (12, 'LIB002');  -- Librarian: Grace Clark
INSERT INTO LIBRARIANS (ID, EmployeeId) VALUES (13, 'LIB003');  -- Librarian: Hank Miller
INSERT INTO LIBRARIANS (ID, EmployeeId) VALUES (14, 'LIB004');  -- Librarian: Ivy Lewis
INSERT INTO LIBRARIANS (ID, EmployeeId) VALUES (15, 'LIB005');  -- Librarian: Jack Walker

-- Insert BookDetails (for each book)
INSERT INTO BOOK_DETAILS (ID, TOTAL_COPIES, BORROWED_COPIES, AVAILABLE_COPIES)
VALUES (1, 10, 2, 8);  -- Book: 'Das Kapital'

INSERT INTO BOOK_DETAILS (ID, TOTAL_COPIES, BORROWED_COPIES, AVAILABLE_COPIES)
VALUES (2, 15, 5, 10);  -- Book: '1984'

INSERT INTO BOOK_DETAILS (ID, TOTAL_COPIES, BORROWED_COPIES, AVAILABLE_COPIES)
VALUES (3, 20, 10, 10);  -- Book: 'Einführung in die Programmierung'

INSERT INTO BOOK_DETAILS (ID, TOTAL_COPIES, BORROWED_COPIES, AVAILABLE_COPIES)
VALUES (4, 5, 1, 4);  -- Book: 'Die Biografie von Albert Einstein'

INSERT INTO BOOK_DETAILS (ID, TOTAL_COPIES, BORROWED_COPIES, AVAILABLE_COPIES)
VALUES (5, 8, 3, 5);  -- Book: 'Der Marsianer'

-- Kunde leiht ein Buch aus
INSERT INTO BOOK_LOANS (CustomerId, BookId, Loan_Date, Due_Date, LibrarianId)
VALUES (6, 1, '2024-01-10', '2024-02-10', 12);
-- Ein weiteres Beispiel mit Rückgabedaten
INSERT INTO BOOK_LOANS (CustomerId, BookId, Loan_Date, Due_Date, LibrarianId,
                       Return_Date, ReturnLibrarianId)
VALUES (7, 3, '2024-02-01', '2024-02-28', 11, '2024-02-20', 13);
-- Noch eine Ausleihe ohne Rückgabedatum
INSERT INTO BOOK_LOANS (CustomerId, BookId, Loan_Date, Due_Date, LibrarianId)
VALUES (8, 2, '2024-02-15', '2024-03-15', 12);
-- Rückgabe eines anderen Buches
INSERT INTO BOOK_LOANS (CustomerId, BookId, Loan_Date, Due_Date, LibrarianId,
                       Return_Date, ReturnLibrarianId)
VALUES (6, 4, '2024-03-05', '2024-04-05', 13, '2024-03-25', 11);