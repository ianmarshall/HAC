﻿create function initcap (@text varchar(4000))
returns varchar(4000)
as

begin
	declare 	@counter int, 
		@length int,
		@char char(1),
		@textnew varchar(4000)

	set @text		= rtrim(@text)
	set @text		= lower(@text)
	set @length 	= len(@text)
	set @counter 	= 1

	set @text = upper(left(@text, 1) ) + right(@text, @length - 1) 

	while @counter <> @length --+ 1
	begin
		select @char = substring(@text, @counter, 1)

		IF @char = space(1)  or @char =  '_' or @char = ','  or @char = '.' or @char = '\'
 or @char = '/' or @char = '(' or @char = ')'
		begin
			set @textnew = left(@text, @counter)  + upper(substring(@text, 
@counter+1, 1)) + right(@text, (@length - @counter) - 1)
			set @text	 = @textnew
		end

		set @counter = @counter + 1
	end

	return @text
end
