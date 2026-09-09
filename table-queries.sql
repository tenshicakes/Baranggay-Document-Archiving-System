-- 1. Create the Users Table (Employee Access Control)
CREATE TABLE Users_tbl (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL
);

-- 2. Create the Resident Master Table (The Core Directory)
CREATE TABLE Resident_Master_tbl (
    ResidentID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(50) NULL,
    Address VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(15) NULL,
    BirthDate DATE NULL
);

-- 3. Create the Derogatory Records Table (The Justice Logs)
CREATE TABLE Derogatory_Records_tbl (
    RecordID INT IDENTITY(1,1) PRIMARY KEY,
    ResidentID INT NOT NULL,
    IncidentDetails TEXT NOT NULL,
    DateLogged DATETIME NOT NULL DEFAULT GETDATE(),
    Status VARCHAR(20) NOT NULL,
    
    -- Foreign Key Relation
    CONSTRAINT FK_Derogatory_Resident FOREIGN KEY (ResidentID) 
    REFERENCES Resident_Master_tbl(ResidentID) ON DELETE CASCADE
);

-- 4. Create the Documents Table (Combines the Queue and Archive)
CREATE TABLE Documents_tbl (
    DocumentID INT IDENTITY(1,1) PRIMARY KEY,
    ResidentID INT NOT NULL,
    DocumentType VARCHAR(50) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    Status VARCHAR(20) NOT NULL,
    ORNumber VARCHAR(50) NULL,
    ReferenceNumber VARCHAR(50) NULL UNIQUE,
    FilePath VARCHAR(255) NULL,
    RequestDate DATETIME NOT NULL DEFAULT GETDATE(),
    ProcessedBy INT NULL,
    
    -- Foreign Key Relations
    CONSTRAINT FK_Document_Resident FOREIGN KEY (ResidentID) 
    REFERENCES Resident_Master_tbl(ResidentID) ON DELETE CASCADE,
    
    CONSTRAINT FK_Document_User FOREIGN KEY (ProcessedBy) 
    REFERENCES Users_tbl(UserID) ON DELETE SET NULL
);