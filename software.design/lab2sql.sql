create table Director(
DirectorId serial,
DirectorName varchar(100),
DirectorDateOfBirth varchar(200),
DirectorRegion varchar(100),
DirectorGender varchar(1)
);

insert into Director(DirectorName,DirectorDateOfBirth,DirectorRegion,DirectorGender) values('Mark Mylod','01-01-1965','England','M');
insert into Director(DirectorName,DirectorDateOfBirth,DirectorRegion,DirectorGender) values('David Lynch','20-01-1946','USA','M');

select * from Director

create table TVShow(
    TVShowId serial,
TVShowName varchar(100),
TVShowLength varchar(200),
TVShowDate date,
Director varchar(100)
);

insert into TVShow(TVShowName,TVShowLength,TVShowDate,Director) values('Game Of Thrones', '46', '17-04-2011','Mark Mylod');
insert into TVShow(TVShowName,TVShowLength,TVShowDate,Director) values('Twin Peaks', '29', '08-04-1990','David Lynch');

select * from TVShow;


