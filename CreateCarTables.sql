CREATE TABLE Make  (
  ID INT NOT NULL,
  CarMaker VARCHAR(20),

  CONSTRAINT PK_Make PRIMARY KEY(ID),
);


CREATE TABLE CarModel (
  ID INT NOT NULL IDENTITY(1,1),
  YearMade INT NOT NULL,
  CarMakerID INT,
  ModelName VARCHAR(20),
  BodyType VARCHAR(20),
  FuelType VARCHAR(20),
  Efficiency NUMERIC(4,1),
  DriverAssist BIT,
  InProduction BIT,
  Color VARCHAR(50),

  CONSTRAINT PK_CarModel PRIMARY KEY(ID),
  CONSTRAINT FK_MakeCarModel FOREIGN KEY (CarMakerID) REFERENCES Make(ID)
);