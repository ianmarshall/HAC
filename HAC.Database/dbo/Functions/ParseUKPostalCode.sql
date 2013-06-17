
CREATE function dbo.ParseUKPostalCode(
    @pPostalCode varchar(8)
)
returns table
as return (select rtrim(left(@pPostalCode,len(@pPostalCode) - 3)) as Outward, right(@pPostalCode,3) as Inward);

