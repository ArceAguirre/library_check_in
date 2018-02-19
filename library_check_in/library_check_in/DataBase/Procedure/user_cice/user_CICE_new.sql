/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   12-02-2018										*/
/*  Description	|   Alta de Usuario									*/
/*  Name		|   user_CICE_new						 			*/
/*  Parameters	|   @user_name varchar(50)not null					*/
/*				|	@user_password varchar(50) not null				*/
/*				|	@father_last_name varchar(50) not null			*/
/*				|	@mother_last_name varchar(50)					*/
/*				|	@id_type_user int not null						*/
/*  Call		|   user_CICE_new @user_name = '',					*/
/*				|	@user_password = '', @father_last_name = '',	*/
/*				|	@mother_last_name = '', @id_type_user = 0		*/
/********************************************************************/
create procedure user_CICE_new @user_name varchar(50), @user_password varchar(50), 
	@father_last_name varchar(50), @mother_last_name varchar(50), @id_type_user int
as
begin
	declare @var_password varchar(50);
	declare @var_id_type_user int; 

	set @user_name = ltrim(rtrim(@user_name));
	set @var_password = ltrim(rtrim(@user_password));
	set @father_last_name = ltrim(rtrim(@father_last_name));
	set @mother_last_name = ltrim(rtrim(@mother_last_name));
	
	select @var_id_type_user = 1|id from type_user where id = @id_type_user and active = 1;
	
	if @user_name = '' or @user_name = null or @user_name is null
	begin
    	select 
            '001' as error,
            'El nombre está vacio' as error_message;
        return
	end
	if @var_password = '' or @var_password = null or @var_password is null
	begin
    	select 
            '002' as error,
            'La contraseña está vacía' as error_message;
        return
	end
	if @father_last_name = '' or @father_last_name = null or @father_last_name is null
	begin
    	select 
            '003' as error,
            'El apellido está vacio' as error_message;
        return
	end
	if @var_id_type_user = '' or @var_id_type_user = null or @var_id_type_user is null or @var_id_type_user = 0
	begin
    	select 
            '004' as error,
            'No existe el tipo de usuario' as error_message;
        return
	end
		insert into user_CICE(user_name, user_password, father_last_name, mother_last_name, id_type_user)
		values(@user_name, @user_password, @father_last_name, @mother_last_name,@id_type_user)
		
		select 
			'000' as error,
			'Correcto' as error_message;
		return	 
end;