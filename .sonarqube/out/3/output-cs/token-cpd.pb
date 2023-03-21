�%
�C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\AeroNaves.webApi\Controllers\AeronaveController.cs
	namespace
	AeroNaves
 
.
webApi
.
Controllers
{
[ 

] 
[ 
Route 
( 	
$str	 
) 
] 
public 
class	 
AeronaveController !
:" #
ControllerBase$ 2
{3 4
private 
readonly 
	IMediator 
	_mediator (
;( )
public 

AeronaveController 
( 
	IMediator '
mediator( 0
)0 1
{2 3
	_mediator 
= 
mediator 
; 
} 
[ 
Route 

(
 
$str 
) 
] 
[ 
HttpPost 
]
public 

async 
Task 
< 

># $
Create% +
(+ ,
[, -
FromBody- 5
]5 6 
CrearAeronaveCommand7 K
commandL S
)S T
{U V
Guid 

id 
= 
await 
	_mediator 
.  
Send  $
($ %
command% ,
), -
;- .
if 
(	 

id
 
==
Guid 
. 
Empty 
) 
return 

BadRequest 
( 
) 
; 
return 
Ok
( 
id 
) 
; 
}   
["" 
Route"" 

(""
 
$str"" 
)"" 
]"" 
[## 
HttpGet## 
]## 
public$$ 

async$$ 
Task$$ 
<$$ 

>$$# $
GetAeronave$$% 0
($$0 1
[$$1 2
	FromRoute$$2 ;
]$$; < 
GetAeronaveByIdQuery$$= Q
command$$R Y
)$$Y Z
{$$[ \
AeronaveDTO%% 
result%% 
=%% 
await%%  
	_mediator%%! *
.%%* +
Send%%+ /
(%%/ 0
command%%0 7
)%%7 8
;%%8 9
if'' 
(''	 

result''
 
=='' 
null'' 
)'' 
return(( 
NotFound(( 
((( 
)(( 
;(( 
return** 
Ok**
(** 
result** 
)** 
;** 
}++ 
[-- 
Route-- 

(--
 
$str-- 
)-- 
]-- 
[.. 
HttpPost.. 
]..
public// 

async// 
Task// 
<// 

>//# $
Search//% +
(//+ ,
[//, -
FromBody//- 5
]//5 6
SearchAeronaveQuery//7 J
query//K P
)//P Q
{//R S
var00 	
	aeronaves00
 
=00 
await00 
	_mediator00 %
.00% &
Send00& *
(00* +
query00+ 0
)000 1
;001 2
if22 
(22	 

	aeronaves22
 
==22 
null22 
)22 
return33 

BadRequest33 
(33 
)33 
;33 
return55 
Ok55
(55 
	aeronaves55 
)55 
;55 
}66 
[88 
Route88 

(88
 
$str88 
)88 
]88 
[99 
HttpGet99 
]99 
public:: 

async:: 
Task:: 
<:: 

>::# $
GetAll::% +
(::+ ,
[::, -
	FromRoute::- 6
]::6 7 
ListAllAeronaveQuery::8 L
command::M T
)::T U
{::V W
List;; 

<;;
 
AeronaveDTO;; 
>;; 
result;; 
=;;  
await;;! &
	_mediator;;' 0
.;;0 1
Send;;1 5
(;;5 6
command;;6 =
);;= >
;;;> ?
if<< 
(<<	 

result<<
 
==<< 
null<< 
)<< 
return== 
NotFound== 
(== 
)== 
;== 
return?? 
Ok??
(?? 
result?? 
)?? 
;?? 
}@@ 
}CC 
}DD �
�C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\AeroNaves.webApi\Controllers\AsignarAeronaveController.cs
	namespace		 	
	AeroNaves		
 
.		 
webApi		 
.		 
Controllers		 &
{		' (
[ 
Route 
( 	
$str	 
) 
] 
[ 

] 
public
class
AsignarAeronaveController
:
ControllerBase
{
private 
readonly 
	IMediator 
	_mediator (
;( )
public 
%
AsignarAeronaveController $
($ %
	IMediator% .
mediator/ 7
)7 8
{9 :
	_mediator 
= 
mediator 
; 
} 
[ 
HttpPost 
]
public 

async 
Task 
< 

># $
AsignarAeronave% 4
(4 5
[5 6
FromBody6 >
]> ?"
AsignarAeronaveCommand@ V
commandW ^
)^ _
{` a
Guid 

id 
= 
await 
	_mediator 
.  
Send  $
($ %
command% ,
), -
;- .
if 
(	 

id
 
==
Guid 
. 
Empty 
) 
return 

BadRequest 
( 
) 
; 
return 
Ok
( 
id 
) 
; 
} 
} 
} �

mC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\AeroNaves.webApi\Program.cs
	namespace 	
	AeroNaves
 
. 
webApi 
{ 
public 
class	 
Program 
{ 
public

static
void
Main
(
string
[
]
args
)
{
CreateHostBuilder 
( 
args 
) 
. 
Build #
(# $
)$ %
.% &
Run& )
() *
)* +
;+ ,
} 
public 

static 
IHostBuilder 
CreateHostBuilder 0
(0 1
string1 7
[7 8
]8 9
args: >
)> ?
=>@ B
Host 
. 
CreateDefaultBuilder
(! "
args" &
)& '
. 
ConfigureWebHostDefaults
(% &

webBuilder& 0
=>1 3
{4 5

webBuilder 
. 

UseStartup #
<# $
Startup$ +
>+ ,
(, -
)- .
;. /
} 
)
; 
} 
} �
mC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\AeroNaves.webApi\Startup.cs
	namespace 	
	AeroNaves
 
. 
webApi 
{ 
[ #
ExcludeFromCodeCoverage 
] 
public 
class	 
Startup 
{ 
public 

Startup 
( 
IConfiguration !

)/ 0
{1 2

= 

;# $
} 
public 

IConfiguration 

{( )
get* -
;- .
}/ 0
public!! 

void!! 
ConfigureServices!! !
(!!! "
IServiceCollection!!" 4
services!!5 =
)!!= >
{!!? @
services&& 
.&& 
AddInfrastructure&&  
(&&  !

)&&. /
;&&/ 0
services(( 
.(( 
AddControllers(( 
((( 
)(( 
;((  
services)) 
.)) 

()) 
c)) 
=>)) !
{))" #
c** 	
.**	 


SwaggerDoc**
 
(** 
$str** 
,** 
new** 
OpenApiInfo** *
{**+ ,
Title**- 2
=**3 4
$str**5 G
,**G H
Version**I P
=**Q R
$str**S W
}**X Y
)**Y Z
;**Z [
}++ 
)++ 
;++ 	
},, 
public// 

void// 
	Configure// 
(// 
IApplicationBuilder// -
app//. 1
,//1 2
IWebHostEnvironment//3 F
env//G J
)//J K
{//L M
app22 	
.22	 


UseSwagger22
 
(22 
)22 
;22 
app33 	
.33	 

UseSwaggerUI33
 
(33 
c33 
=>33 
c33 
.33 
SwaggerEndpoint33 -
(33- .
$str33. H
,33H I
$str33J _
)33_ `
)33` a
;33a b
app66 	
.66	 

UseHttpsRedirection66
 
(66 
)66 
;66  
app88 	
.88	 


UseRouting88
 
(88 
)88 
;88 
app:: 	
.::	 

UseAuthorization::
 
(:: 
):: 
;:: 
app<< 	
.<<	 

UseEndpoints<<
 
(<< 
	endpoints<<  
=><<! #
{<<$ %
	endpoints== 
.== 
MapControllers==  
(==  !
)==! "
;==" #
}>> 
)>> 
;>> 	
}EE 
}FF 
}GG 