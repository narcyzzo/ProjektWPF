CREATE TABLE [dbo].[SPECIES] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[PETS] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (20) NOT NULL,
    [DateOfBirth] DATE         NOT NULL,
    [Id_Species]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id_Species]) REFERENCES [dbo].[SPECIES] ([Id])
);


CREATE TABLE [dbo].[DOCTORS] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (30) NOT NULL,
    [LastName]    VARCHAR (30) NOT NULL,
    [PhoneNumber] VARCHAR (9)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([PhoneNumber] ASC)
);


CREATE TABLE [dbo].[APPOINTMENTS] (
    [Id]                INT      IDENTITY (1, 1) NOT NULL,
    [DateOfAppointment] DATETIME NOT NULL,
    [Price]             MONEY    NOT NULL,
    [Id_Pet]            INT      NOT NULL,
    [Id_Doctor]         INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id_Pet]) REFERENCES [dbo].[PETS] ([Id]),
    FOREIGN KEY ([Id_Doctor]) REFERENCES [dbo].[DOCTORS] ([Id])
);



INSERT INTO SPECIES(Name) VALUES('Dog');
INSERT INTO SPECIES(Name) VALUES('Cat');
INSERT INTO SPECIES(Name) VALUES('Lizard');
INSERT INTO SPECIES(Name) VALUES('Bird');

INSERT INTO PETS(Name, DateOfBirth, Id_Species) VALUES('Rudolf', '2013-10-10', 1);
INSERT INTO PETS(Name, DateOfBirth, Id_Species) VALUES('Jeremy', '2017-05-01', 2);
INSERT INTO PETS(Name, DateOfBirth, Id_Species) VALUES('Alan', '2020-12-07', 4);

INSERT INTO DOCTORS(FirstName, LastName, PhoneNumber) VALUES('Rajan', 'Verma', '395834587');
INSERT INTO DOCTORS(FirstName, LastName, PhoneNumber) VALUES('Mateusz', 'Kupiec', '697847365');
INSERT INTO DOCTORS(FirstName, LastName, PhoneNumber) VALUES('John', 'Smith', '345968365');

INSERT INTO APPOINTMENTS(DateOfAppointment, Price, Id_Pet, Id_Doctor) VALUES('20120618 10:34:09 AM', 200.00, 1, 1);