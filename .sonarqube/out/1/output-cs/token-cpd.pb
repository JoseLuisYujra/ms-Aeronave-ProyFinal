Œ

äC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\Dto\Aeronave\AeronaveAsientosDTO.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
Dto "
." #
Aeronave# +
{, -
public 
class	 
AeronaveAsientosDTO "
{# $
public		 

Guid		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		  
public

 

Guid

 

AeronaveId

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 

string 
ClaseAsiento 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 

string 
	Ubicacion 
{ 
get !
;! "
set# &
;& '
}( )
public 

int 
NroSilla 
{ 
get 
; 
set "
;" #
}$ %
public 

string 
EstadoAsiento 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} Ï
ÇC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\Dto\Aeronave\AeronaveDTO.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
Dto "
." #
Aeronave# +
{, -
public

 
class

	 
AeronaveDTO

 
{

 
public 

Guid 
Id 
{ 
get 
; 
set 
; 
}  
public 

string 
CodAeronave 
{ 
get  #
;# $
set% (
;( )
}* +
public 

string 
Marca 
{ 
get 
; 
set "
;" #
}$ %
public 

string 
Modelo 
{ 
get 
; 
set  #
;# $
}% &
public 

int 
NroAsientos 
{ 
get  
;  !
set" %
;% &
}' (
public 

decimal 
CapacidadCarga !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 

decimal  
CapTanqueCombustible '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 

string &
AereopuertoEstacionamiento ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 

string 
EstadoAeronave  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

List 
< 
AeronaveAsientosDTO #
># $
AsientosAeronave% 5
;5 6
public 

AeronaveDTO 
( 
) 
{ 
AsientosAeronave 
= 
new 
List !
<! "
AeronaveAsientosDTO" 5
>5 6
(6 7
)7 8
;8 9
} 
} 
} ª
tC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\Extensions.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
{  
public 
static	 
class 

Extensions  
{! "
public 

static 
IServiceCollection $
AddApplication% 3
(3 4
this4 8
IServiceCollection9 K
servicesL T
)T U
{V W
services 
. 

AddMediatR 
( 
Assembly "
." # 
GetExecutingAssembly# 7
(7 8
)8 9
)9 :
;: ;
services 
. 
AddTransient 
< 
IAeoronaveService -
,- .
AeronaveService/ >
>> ?
(? @
)@ A
;A B
services 
. 
AddTransient 
< 
IAeronaveFactory ,
,, -
AeronaveFactory. =
>= >
(> ?
)? @
;@ A
return 
services 
; 
} 
private 
static 
void 
AddRabbitMq #
(# $
this$ (
IServiceCollection) ;
services< D
)D E
{F G
services!! 
.!! 
AddTransient!! 
<!! 
IRabbitEventBus!! +
,!!+ ,
RabbitEventBus!!- ;
>!!; <
(!!< =
)!!= >
;!!> ?
services'' 
.'' 
AddTransient'' 
<'' 
IEventoManejador'' ,
<'', -&
VueloAsignadoAeronaveQueue''- G
>''G H
,''H I#
AeronaveEventoManejador''J a
>''a b
(''b c
)''c d
;''d e
})) 
}++ 
},, Ë
wC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\ExtensionsApp.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
{  
public 
static	 
class 
ExtensionsApp #
{$ %
public 

static 
IApplicationBuilder %
RabbitMQConsumer& 6
(6 7
this7 ;
IApplicationBuilder< O
appP S
)S T
{U V
var 	
eventBus
 
= 
app 
. 
ApplicationServices ,
., -
GetRequiredService- ?
<? @
IRabbitEventBus@ O
>O P
(P Q
)Q R
;R S
eventBus 
. 
	Subscribe 
< &
VueloAsignadoAeronaveQueue 3
,3 4#
AeronaveEventoManejador5 L
>L M
(M N
)N O
;O P
return 
app 
; 
} 
} 
} Î
ÇC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\Services\AeronaveService.cs
	namespace		 	
	Aeronaves		
 
.		 

Aplication		 
.		 
Services		 '
{		( )
public 
class	 
AeronaveService 
:  
IAeoronaveService! 2
{3 4
public 

Task 
< 
string 
> "
GenerarIdAeronaveAsync .
(. /
)/ 0
{1 2
return 
Task 
. 

FromResult 
( 
GeneradorCodigo ,
(, -
$num- /
)/ 0
)0 1
;1 2
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
string 
GeneradorCodigo (
(( )
int) ,
length- 3
)3 4
{5 6
Random 
random 
= 
new 
Random  
(  !
)! "
;" #
const 
string 

characters 
= 
$str  F
;F G
return 
new 
string 
( 

Enumerable "
." #
Repeat# )
() *

characters* 4
,4 5
length6 <
)< =
. 	
Select	 
( 
s 
=> 
s 
[ 
random 
. 
Next "
(" #
s# $
.$ %
Length% +
)+ ,
], -
)- .
.. /
ToArray/ 6
(6 7
)7 8
)8 9
;9 :
} 
} 
} ò
ÑC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\Services\IAeoronaveService.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
Services '
{( )
public 
	interface	 
IAeoronaveService $
{% &
Task		 
<		 	
string			 
>		 "
GenerarIdAeronaveAsync		 '
(		' (
)		( )
;		) *
} 
} ◊
§C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Command\Aeronaves\ActualizarEstadoAeronaveHandler.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
UseCases '
.' (
Command( /
./ 0
	Aeronaves0 9
{: ;
public 
class	 +
ActualizarEstadoAeronaveHandler .
:/ 0 
INotificationHandler1 E
<E F%
AeronaveEstadoActualizadoF _
>_ `
{a b
private 
readonly 
IAeronaveRepository ( 
_IAeronaveRepository) =
;= >
public 
+
ActualizarEstadoAeronaveHandler *
(* +
IAeronaveRepository+ >
iaeronaveRepository? R
)R S
{T U 
_IAeronaveRepository 
= 
iaeronaveRepository 0
;0 1
} 
public 

async 
Task 
Handle 
( %
AeronaveEstadoActualizado 6
notification7 C
,C D
CancellationTokenE V
cancellationTokenW h
)h i
{j k
Aeronave 
objAeronave 
= 
await " 
_IAeronaveRepository# 7
.7 8
FindByIdAsync8 E
(E F
notificationF R
.R S

IdAeronaveS ]
)] ^
;^ _
objAeronave 
. 1
%ActualizarEstadoMantenimientoAeronave 7
(7 8
)8 9
;9 :
await  
_IAeronaveRepository  
.  !
UpdateAsync! ,
(, -
objAeronave- 8
)8 9
;9 :
} 
} 
} ﬁ
´C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Command\Aeronaves\AsignarAeronave\AsignarAeronaveCommand.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
UseCases '
.' (
Command( /
./ 0
	Aeronaves0 9
.9 :
AsignarAeronave: I
{J K
public		 
class			 "
AsignarAeronaveCommand		 %
:		& '
IRequest		( 0
<		0 1
Guid		1 5
>		5 6
{		7 8
public

 

Guid

 
Id

 
{

 
get

 
;

 
set

 
;

 
}

  
public 
"
AsignarAeronaveCommand !
(! "
Guid" &
id' )
)) *
{+ ,
Id 
=	 

id 
; 
} 
} 
} Ê
´C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Command\Aeronaves\AsignarAeronave\AsignarAeronaveHandler.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
UseCases '
.' (
Command( /
./ 0
	Aeronaves0 9
.9 :
AsignarAeronave: I
{J K
public 
class	 "
AsignarAeronaveHandler %
:& '
IRequestHandler( 7
<7 8"
AsignarAeronaveCommand8 N
,N O
GuidP T
>T U
{V W
private 
readonly 
IAeronaveRepository (
_aeronaveRepository) <
;< =
private 
readonly 
ILogger 
< "
AsignarAeronaveHandler 3
>3 4
_logger5 <
;< =
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
public 
"
AsignarAeronaveHandler !
(! "
IAeronaveRepository" 5
aeronaveRepository6 H
,H I
ILogger 
< "
AsignarAeronaveHandler %
>% &
logger' -
,- .
IUnitOfWork 

unitOfWork 
) 
{	 

_aeronaveRepository 
= 
aeronaveRepository .
;. /
_logger 
= 
logger 
; 
_unitOfWork 
= 

unitOfWork 
; 
} 
public!! 

async!! 
Task!! 
<!! 
Guid!! 
>!! 
Handle!! "
(!!" #"
AsignarAeronaveCommand!!# 9
request!!: A
,!!A B
CancellationToken!!C T
cancellationToken!!U f
)!!f g
{!!h i
try"" 	
{""
 
Aeronave## 
objAeronave## 
=## 
await## $
_aeronaveRepository##% 8
.##8 9
FindByIdAsync##9 F
(##F G
request##G N
.##N O
Id##O Q
)##Q R
;##R S
objAeronave$$ 
.$$ $
ActualizarEstadoAeronave$$ ,
($$, -
)$$- .
;$$. /
await%% 
_aeronaveRepository%% !
.%%! "
UpdateAsync%%" -
(%%- .
objAeronave%%. 9
)%%9 :
;%%: ;
await&& 
_unitOfWork&& 
.&& 
Commit&&  
(&&  !
)&&! "
;&&" #
return'' 
objAeronave'' 
.'' 
Id'' 
;'' 
}(( 
catch(( 
((( 
	Exception(( 
ex(( 
)(( 
{(( 
_logger)) 
.)) 
LogError)) 
()) 
ex)) 
,)) 
$str)) E
)))E F
;))F G
}** 
return++ 
Guid++ 
.++ 
Empty++ 
;++ 
},, 
}-- 
}.. ú
ßC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Command\Aeronaves\CrearAeronave\CrearAeronaveCommand.cs
	namespace		 	
	Aeronaves		
 
.		 

Aplication		 
.		 
UseCases		 '
.		' (
Command		( /
.		/ 0
	Aeronaves		0 9
.		9 :
CrearAeronave		: G
{		H I
public

 
class

	  
CrearAeronaveCommand

 #
:

$ %
IRequest

& .
<

. /
Guid

/ 3
>

3 4
{

5 6
public 

string 
CodAeronave 
{ 
get  #
;# $
set% (
;( )
}* +
public 

string 
Marca 
{ 
get 
; 
set "
;" #
}$ %
public 

string 
Modelo 
{ 
get 
; 
set  #
;# $
}% &
public 

int 
NroAsientos 
{ 
get  
;  !
set" %
;% &
}' (
public 

decimal 
CapacidadCarga !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 

decimal  
CapTanqueCombustible '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 

string &
AereopuertoEstacionamiento ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 

List 
< 
AeronaveAsientosDTO #
># $#
DetalleAeronaveAsientos% <
{= >
get? B
;B C
setD G
;G H
}I J
public 
 
CrearAeronaveCommand 
(  
string  &
codAeronave' 2
,2 3
string4 :
marca; @
,@ A
stringB H
modeloI O
,O P
intQ T
nroasientosU `
,` a
decimalb i
capacidadcargaj x
,x y
decimal	z Å"
captanquecombustible
Ç ñ
,
ñ ó
string
ò û(
aereopuertoEstacionamiento
ü π
,
π ∫
List
ª ø
<
ø ¿!
AeronaveAsientosDTO
¿ ”
>
” ‘%
detalleAeronaveAsientos
’ Ï
)
Ï Ì
{
Ó Ô
CodAeronave 
= 
codAeronave 
;  
Marca 
= 
marca 
; 
Modelo 
= 
modelo 
; 
NroAsientos 
= 
nroasientos 
;  
CapacidadCarga 
= 
capacidadcarga %
;% & 
CapTanqueCombustible 
=  
captanquecombustible 1
;1 2&
AereopuertoEstacionamiento  
=! "&
aereopuertoEstacionamiento# =
;= >#
DetalleAeronaveAsientos 
= #
detalleAeronaveAsientos  7
;7 8
} 
public   
 
CrearAeronaveCommand   
(    
)    !
{  " #
}  $ %
}"" 
}## °)
ßC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Command\Aeronaves\CrearAeronave\CrearAeronaveHandler.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
UseCases '
.' (
Command( /
./ 0
	Aeronaves0 9
.9 :
CrearAeronave: G
{H I
public 
class	  
CrearAeronaveHandler #
:$ %
IRequestHandler& 5
<5 6 
CrearAeronaveCommand6 J
,J K
GuidL P
>P Q
{R S
private 
readonly 
IAeronaveRepository (
_aeronaveRepository) <
;< =
private 
readonly 
ILogger 
<  
CrearAeronaveHandler 1
>1 2
_logger3 :
;: ;
private 
readonly 
IAeoronaveService &
_aeoronaveService' 8
;8 9
private 
readonly 
IAeronaveFactory %
_aeronaveFactory& 6
;6 7
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
public 
 
CrearAeronaveHandler 
(  
IAeronaveRepository  3
aeronaveRepository4 F
,F G
ILogger   
<    
CrearAeronaveHandler   $
>  $ %
logger  & ,
,  , -
IAeoronaveService!! 
aeoronaveService!! *
,!!* +
IAeronaveFactory"" 
aeronaveFactory"" (
,""( )
IUnitOfWork## 

unitOfWork## 
)%% 	
{%%
 
_aeronaveRepository&& 
=&& 
aeronaveRepository&& .
;&&. /
_logger'' 
='' 
logger'' 
;'' 
_aeoronaveService(( 
=(( 
aeoronaveService(( *
;((* +
_aeronaveFactory)) 
=)) 
aeronaveFactory)) (
;))( )
_unitOfWork** 
=** 

unitOfWork** 
;** 
},, 
public.. 

async.. 
Task.. 
<.. 
Guid.. 
>.. 
Handle.. "
(.." # 
CrearAeronaveCommand..# 7
request..8 ?
,..? @
CancellationToken..A R
cancellationToken..S d
)..d e
{..f g
try// 	
{//
 
string00 
codigoAeronave00 
=00 
await00  %
_aeoronaveService00& 7
.007 8"
GenerarIdAeronaveAsync008 N
(00N O
)00O P
;00P Q
string11 
_estadoASiento11 
=11 
$str11  '
;11' (
Aeronave22 
objaeronave22 
=22 
_aeronaveFactory22 /
.22/ 0
Create220 6
(226 7
codigoAeronave227 E
,22E F
request22G N
.22N O
Marca22O T
,22T U
request22V ]
.22] ^
Modelo22^ d
,22d e
request22f m
.22m n
NroAsientos22n y
,22y z
request	22{ Ç
.
22Ç É
CapacidadCarga
22É ë
,
22ë í
request
22ì ö
.
22ö õ"
CapTanqueCombustible
22õ Ø
,
22Ø ∞
request
22± ∏
.
22∏ π(
AereopuertoEstacionamiento
22π ”
)
22” ‘
;
22‘ ’
if44 

(44 
request44 
.44 #
DetalleAeronaveAsientos44 +
!=44, .
null44/ 3
)443 4
{445 6
foreach55
 
(55 
var55 
item55 
in55 
request55 &
.55& '#
DetalleAeronaveAsientos55' >
)55> ?
{55@ A
objaeronave66 
.66 
AgregarAsiento66 &
(66& '
item66' +
.66+ ,

AeronaveId66, 6
,666 7
item668 <
.66< =
ClaseAsiento66= I
,66I J
item66K O
.66O P
	Ubicacion66P Y
,66Y Z
item66[ _
.66_ `
NroSilla66` h
,66h i
_estadoASiento66j x
)66x y
;66y z
}77
 
}88 	
objaeronave:: 
.:: 
RegistroAeronave:: $
(::$ %
)::% &
;::& '
await;; 
_aeronaveRepository;; !
.;;! "
CreateAsync;;" -
(;;- .
objaeronave;;. 9
);;9 :
;;;: ;
await<< 
_unitOfWork<< 
.<< 
Commit<<  
(<<  !
)<<! "
;<<" #
returnAA 
objaeronaveAA 
.AA 
IdAA 
;AA 
}BB 
catchBB 
(BB 
	ExceptionBB 
exBB 
)BB 
{BB 
_loggerCC 
.CC 
LogErrorCC 
(CC 
exCC 
,CC 
$strCC 6
)CC6 7
;CC7 8
}DD 
returnEE 
GuidEE 
.EE 
EmptyEE 
;EE 
}FF 
}GG 
}HH ¸
öC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\ManejadorRabbit\AeronaveEventoManejador.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
UseCases '
.' (
ManejadorRabbit( 7
{8 9
public 
class	 #
AeronaveEventoManejador &
:' (
IEventoManejador) 9
<9 :&
VueloAsignadoAeronaveQueue: T
>T U
{V W
public 

Task 
Handle 
( &
VueloAsignadoAeronaveQueue 1
@evento2 9
)9 :
{; <
var 	
url
 
= 
$str K
;K L
var 	
request
 
= 
( 
HttpWebRequest #
)# $

WebRequest$ .
.. /
Create/ 5
(5 6
url6 9
)9 :
;: ;
request 
. 
Accept 
= 
$str )
;) *
request 
. 
ContentType 
= 
$str .
;. /
request 
. 
Method 
= 
$str 
; 
request 
. 
Timeout 
= 
$num 
; 
var 	
json
 
= 
JsonConvert 
. 
SerializeObject ,
(, -
evento- 3
)3 4
;4 5
ASCIIEncoding 
encoding 
= 
new "
ASCIIEncoding# 0
(0 1
)1 2
;2 3
Byte 

[
 
] 
bytes 
= 
encoding 
. 
GetBytes &
(& '
json' +
)+ ,
;, -
Stream!! 
	newStream!! 
=!! 
request!!  
.!!  !
GetRequestStream!!! 1
(!!1 2
)!!2 3
;!!3 4
	newStream"" 
."" 
Write"" 
("" 
bytes"" 
,"" 
$num"" 
,"" 
bytes""  %
.""% &
Length""& ,
)"", -
;""- .
	newStream## 
.## 
Close## 
(## 
)## 
;## 
try&& 	
{&&
 
var'' 
response'' 
='' 
request'' 
.'' 
GetResponse'' *
(''* +
)''+ ,
;'', -
}(( 
catch(( 
((( 
	Exception(( 
ex(( 
)(( 
{(( 
}((  
return** 
Task** 
.** 
CompletedTask** 
;**  
},, 
}-- 
}.. ë&
´C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Queries\Aeronaves\GetAeronaveById\GetAeronaveByIdHandler.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
UseCases '
.' (
Queries( /
./ 0
	Aeronaves0 9
.9 :
GetAeronaveById: I
{J K
public 
class	 "
GetAeronaveByIdHandler %
:& '
IRequestHandler( 7
<7 8 
GetAeronaveByIdQuery8 L
,L M
AeronaveDTON Y
>Y Z
{[ \
private 
readonly 
IAeronaveRepository (
_aeronaveRepository) <
;< =
private 
readonly 
ILogger 
<  
GetAeronaveByIdQuery 1
>1 2
_logger3 :
;: ;
public 
"
GetAeronaveByIdHandler !
(! "
IAeronaveRepository" 5
aeronaveRepository6 H
,H I
ILoggerJ Q
<Q R 
GetAeronaveByIdQueryR f
>f g
loggerh n
)n o
{p q
_aeronaveRepository 
= 
aeronaveRepository .
;. /
_logger 
= 
logger 
; 
} 
public 

async 
Task 
< 
AeronaveDTO !
>! "
Handle# )
() * 
GetAeronaveByIdQuery* >
request? F
,F G
CancellationTokenH Y
cancellationTokenZ k
)k l
{m n
AeronaveDTO 
result 
= 
null 
;  
try 	
{
 
var 
objAeronave 
= 
await 
_aeronaveRepository  3
.3 4
FindByIdAsync4 A
(A B
requestB I
.I J
IdJ L
)L M
;M N
result 
= 
new 
AeronaveDTO  
(  !
)! "
{# $
Id
 
= 
objAeronave 
. 
Id 
, 
CodAeronave
 
= 
objAeronave #
.# $
CodAeronave$ /
,/ 0
Marca  
 
=   
objAeronave   
.   
Marca   #
,  # $
Modelo!!
 
=!! 
objAeronave!! 
.!! 
Modelo!! %
,!!% &
NroAsientos""
 
="" 
objAeronave"" #
.""# $
NroAsientos""$ /
,""/ 0
CapacidadCarga##
 
=## 
objAeronave## &
.##& '
CapacidadCarga##' 5
,##5 6 
CapTanqueCombustible$$
 
=$$  
objAeronave$$! ,
.$$, - 
CapTanqueCombustible$$- A
,$$A B&
AereopuertoEstacionamiento%%
 $
=%%% &
objAeronave%%' 2
.%%2 3&
AereopuertoEstacionamiento%%3 M
,%%M N
EstadoAeronave&&
 
=&& 
objAeronave&& &
.&&& '
EstadoAeronave&&' 5
}'' 	
;''	 

foreach(( 
((( 
var(( 
item(( 
in(( 
objAeronave(( (
.((( )
DetalleAsientos(() 8
)((8 9
{((: ;
result))
 
.)) 
AsientosAeronave)) !
.))! "
Add))" %
())% &
new))& )
AeronaveAsientosDTO))* =
())= >
)))> ?
{))@ A
Id** 
=** 
item** 
.** 
Id** 
,** 

AeronaveId++ 
=++ 
item++ 
.++ 

AeronaveId++ (
,++( )
ClaseAsiento,, 
=,, 
item,, 
.,,  
ClaseAsiento,,  ,
,,,, -
	Ubicacion-- 
=-- 
item-- 
.-- 
	Ubicacion-- &
,--& '
NroSilla.. 
=.. 
item.. 
... 
NroSilla.. $
,..$ %
EstadoAsiento// 
=// 
item//  
.//  !
EstadoAsiento//! .
}00
 
)00 
;00 
}11 	
}22 
catch22 
(22 
	Exception22 
ex22 
)22 
{22 
_logger33 
.33 
LogError33 
(33 
ex33 
,33 
$str33 G
,33G H
request33I P
.33P Q
Id33Q S
)33S T
;33T U
}44 
return66 
result66 
;66 
}77 
}88 
}99 —
©C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Queries\Aeronaves\GetAeronaveById\GetAeronaveByIdQuery.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
UseCases '
.' (
Queries( /
./ 0
	Aeronaves0 9
.9 :
GetAeronaveById: I
{J K
public 
class	  
GetAeronaveByIdQuery #
:$ %
IRequest& .
<. /
AeronaveDTO/ :
>: ;
{< =
public 

Guid 
Id 
{ 
get 
; 
set 
; 
}  
public 
 
GetAeronaveByIdQuery 
(  
Guid  $
id% '
)' (
{) *
Id 
=	 

id 
; 
} 
public 
 
GetAeronaveByIdQuery 
(  
)  !
{" #
}$ %
} 
} ã
°C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Queries\Aeronaves\ListAll\ListAllAeronaveQuery.cs
	namespace		 	
	Aeronaves		
 
.		 

Aplication		 
.		 
UseCases		 '
.		' (
Queries		( /
.		/ 0
	Aeronaves		0 9
.		9 :
ListAll		: A
{		B C
public

 
class

	  
ListAllAeronaveQuery

 #
:

$ %
IRequest

& .
<

. /
List

/ 3
<

3 4
AeronaveDTO

4 ?
>

? @
>

@ A
{

B C
public 
 
ListAllAeronaveQuery 
(  
)  !
{" #
}$ %
} 
} Í+
®C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Queries\Aeronaves\ListAll\ListAllAeronaveQueryHandler.cs
	namespace 	
	Aeronaves
 
. 

Aplication 
. 
UseCases '
.' (
Queries( /
./ 0
	Aeronaves0 9
.9 :
ListAll: A
{B C
public 
class	 '
ListAllAeronaveQueryHandler *
:+ ,
IRequestHandler- <
<< = 
ListAllAeronaveQuery= Q
,Q R
ListS W
<W X
AeronaveDTOX c
>c d
>d e
{f g
private 
readonly 
IAeronaveRepository (
_aeronaveRepository) <
;< =
private 
readonly 
ILogger 
<  
ListAllAeronaveQuery 1
>1 2
_logger3 :
;: ;
public 
'
ListAllAeronaveQueryHandler &
(& '
IAeronaveRepository' :
aeronaveRepository; M
,M N
ILoggerO V
<V W 
ListAllAeronaveQueryW k
>k l
loggerm s
)s t
{u v
_aeronaveRepository 
= 
aeronaveRepository .
;. /
_logger 
= 
logger 
; 
} 
public 

async 
Task 
< 
List 
< 
AeronaveDTO &
>& '
>' (
Handle) /
(/ 0 
ListAllAeronaveQuery0 D
requestE L
,L M
CancellationTokenN _
cancellationToken` q
)q r
{s t
List 

<
 
AeronaveDTO 
> 
result 
=  
new! $
List% )
<) *
AeronaveDTO* 5
>5 6
(6 7
)7 8
;8 9
try 	
{
 
List 
< 
Aeronave 
> 
DetalleAeronave &
=' (
await) .
_aeronaveRepository/ B
.B C
GetAllC I
(I J
)J K
;K L
foreach 
( 
var 
objAeronave  
in! #
DetalleAeronave$ 3
)3 4
{5 6
AeronaveDTO
 
aeronavelist "
=# $
new% (
AeronaveDTO) 4
(4 5
)5 6
{7 8
Id   
=   
objAeronave   
.   
Id   
,    
CodAeronave!! 
=!! 
objAeronave!! %
.!!% &
CodAeronave!!& 1
,!!1 2
Marca"" 
="" 
objAeronave"" 
.""  
Marca""  %
,""% &
Modelo## 
=## 
objAeronave##  
.##  !
Modelo##! '
,##' (
NroAsientos$$ 
=$$ 
objAeronave$$ %
.$$% &
NroAsientos$$& 1
,$$1 2
CapacidadCarga%% 
=%% 
objAeronave%% (
.%%( )
CapacidadCarga%%) 7
,%%7 8 
CapTanqueCombustible&&  
=&&! "
objAeronave&&# .
.&&. / 
CapTanqueCombustible&&/ C
,&&C D&
AereopuertoEstacionamiento'' &
=''' (
objAeronave'') 4
.''4 5&
AereopuertoEstacionamiento''5 O
,''O P
EstadoAeronave(( 
=(( 
objAeronave(( (
.((( )
EstadoAeronave(() 7
}))
 
;)) 
foreach++
 
(++ 
var++ 
item++ 
in++ 
objAeronave++ *
.++* +
DetalleAsientos+++ :
)++: ;
{++< =
aeronavelist,, 
.,, 
AsientosAeronave,, )
.,,) *
Add,,* -
(,,- .
new,,. 1
AeronaveAsientosDTO,,2 E
(,,E F
),,F G
{,,H I
Id-- 
=-- 
item-- 
.-- 
Id-- 
,-- 

AeronaveId.. 
=.. 
item.. 
...  

AeronaveId..  *
,..* +
ClaseAsiento// 
=// 
item// !
.//! "
ClaseAsiento//" .
,//. /
	Ubicacion00 
=00 
item00 
.00 
	Ubicacion00 (
,00( )
NroSilla11 
=11 
item11 
.11 
NroSilla11 &
,11& '
EstadoAsiento22 
=22 
item22 "
.22" #
EstadoAsiento22# 0
}33 
)33 
;33 
}44
 
result55
 
.55 
Add55 
(55 
aeronavelist55 !
)55! "
;55" #
}66 	
}77 
catch77 
(77 
	Exception77 
ex77 
)77 
{77 
_logger88 
.88 
LogError88 
(88 
ex88 
,88 
$str88 Q
)88Q R
;88R S
}99 
return:: 
result:: 
.:: 
OrderBy:: 
(:: 
orden:: !
=>::" $
orden::% *
.::* +
CodAeronave::+ 6
)::6 7
.::7 8
ToList::8 >
(::> ?
)::? @
;::@ A
};; 
}== 
}>> â
ßC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Aplication\UseCases\Queries\Aeronaves\SearchAeronave\SearchAeronaveQuery.cs
	namespace		 	
	Aeronaves		
 
.		 

Aplication		 
.		 
UseCases		 '
.		' (
Queries		( /
.		/ 0
	Aeronaves		0 9
.		9 :
SearchAeronave		: H
{		I J
public 
class	 
SearchAeronaveQuery "
:# $
IRequest% -
<- .
AeronaveDTO. 9
>9 :
{; <
public 

Guid 
Id 
{ 
get 
; 
set 
; 
}  
} 
} 