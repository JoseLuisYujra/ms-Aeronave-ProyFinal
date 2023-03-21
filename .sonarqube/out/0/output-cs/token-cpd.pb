«
|C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Event\AeronaveAgregada.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
Event  
{! "
public 
record	 
AeronaveAgregada  
:! "
DomainEvent# .
{/ 0
public 

Guid 

IdAeronave 
{ 
get  
;  !
}" #
public 

string 
CodAeronave 
{ 
get  #
;# $
}% &
public 

string 
Marca 
{ 
get 
; 
set "
;" #
}$ %
public 

string 
Modelo 
{ 
get 
; 
set  #
;# $
}% &
public 

int 
NroAsientos 
{ 
get  
;  !
set" %
;% &
}' (
public 

decimal 
CapacidadCarga !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 

decimal  
CapTanqueCombustible '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 

string &
AereopuertoEstacionamiento ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 

string 
EstadoAeronave  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

List 
< +
DetalleAeronaveAsientosAgregado /
>/ 0#
DetalleAeronaveAsientos1 H
{I J
getK N
;N O
initP T
;T U
}V W
public 

record +
DetalleAeronaveAsientosAgregado 1
(1 2
string2 8
asientosClases9 G
,G H
stringI O
asientosUbicacionP a
,a b
intc f
nrosillag o
,o p
stringq w
asientosStatus	x Ü
)
Ü á
;
á à
public 

AeronaveAgregada 
( 
Guid  

idAeronave! +
,+ ,
string- 3
codAeronave4 ?
,? @
stringA G
marcaH M
,M N
stringO U
modeloV \
,\ ]
int^ a
nroAsientosb m
,m n
decimalo v
capacidadCarga	w Ö
,
Ö Ü
decimal
á é"
capTanqueCombustible
è £
,
£ §
string !&
aereopuertoEstacionamiento" <
)< =
:> ?
base@ D
(D E
DateTimeE M
.M N
NowN Q
)Q R
{S T

IdAeronave 
= 

idAeronave 
; 
CodAeronave   
=   
codAeronave   
;    
Marca!! 
=!! 
marca!! 
;!! 
Modelo"" 
="" 
modelo"" 
;"" 
NroAsientos## 
=## 
nroAsientos## 
;##  
CapacidadCarga$$ 
=$$ 
capacidadCarga$$ %
;$$% & 
CapTanqueCombustible%% 
=%%  
capTanqueCombustible%% 1
;%%1 2&
AereopuertoEstacionamiento&&  
=&&! "&
aereopuertoEstacionamiento&&# =
;&&= >
}'' 
})) 
}** °	
ÖC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Event\AeronaveEstadoActualizado.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
Event  
{! "
public		 
record			 %
AeronaveEstadoActualizado		 )
:		* +
DomainEvent		, 7
{		8 9
public

 

Guid

 

IdAeronave
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
  !
}

" #
public 

string 
EstadoAeronave  
{! "
get# &
;& '
}( )
public 
%
AeronaveEstadoActualizado $
($ %
Guid% )

idaeronave* 4
,4 5
string6 <
estadoAeronave= K
)K L
:M N
baseO S
(S T
DateTimeT \
.\ ]
Now] `
)` a
{b c

IdAeronave 
= 

idaeronave 
; 
EstadoAeronave 
= 
estadoAeronave %
;% &
} 
} 
} ∑
{C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Event\AsientoAgregado.cs
	namespace		 	
	Aeronaves		
 
.		 
Domain		 
.		 
Event		  
{		! "
public

 
record

	 
AsientoAgregado

 
:

  !
DomainEvent

" -
{

. /
public 

Guid 

AeronaveId 
{ 
get  
;  !
private" )
set* -
;- .
}/ 0
public 

string 
ClaseAsiento 
{  
get! $
;$ %
private& -
set. 1
;1 2
}3 4
public 

string 
	Ubicacion 
{ 
get !
;! "
private# *
set+ .
;. /
}0 1
public 

int 
NroSilla 
{ 
get 
; 
private &
set' *
;* +
}, -
public 

string 
EstadoAsiento 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 

AsientoAgregado 
( 
Guid 

aeronaveId  *
,* +
string, 2
asientosClases3 A
,A B
stringC I
asientosUbicacionJ [
,[ \
int] `
nrosillaa i
,i j
stringk q
estadoAsientor 
)	 Ä
:
Å Ç
base
É á
(
á à
DateTime
à ê
.
ê ë
Now
ë î
)
î ï
{
ñ ó

AeronaveId 
= 

aeronaveId 
; 
ClaseAsiento 
= 
asientosClases #
;# $
	Ubicacion 
= 
asientosUbicacion #
;# $
NroSilla 
= 
nrosilla 
; 
EstadoAsiento 
= 
estadoAsiento #
;# $
} 
} 
} Ã

}C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Factory\AeronaveFactory.cs
	namespace		 	
	Aeronaves		
 
.		 
Domain		 
.		 
Factory		 "
{		# $
public

 
class

	 
AeronaveFactory

 
:

  
IAeronaveFactory

! 1
{

2 3
public 

Aeronave 
Create 
( 
string !
codAeronave" -
,- .
string/ 5
marca6 ;
,; <
string= C
modeloD J
,J K
intL O
nroasientosP [
,[ \
decimal] d
capacidadcargae s
,s t
decimalu |!
captanquecombustible	} ë
,
ë í
string
ì ô(
aereopuertoEstacionamiento
ö ¥
)
¥ µ
{
∂ ∑
return 
new 
Aeronave 
( 
codAeronave %
,% &
marca' ,
,, -
modelo. 4
,4 5
nroasientos6 A
,A B
capacidadcargaC Q
,Q R 
captanquecombustibleS g
,g h'
aereopuertoEstacionamiento	i É
)
É Ñ
;
Ñ Ö
} 
} 
} ¸
~C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Factory\IAeronaveFactory.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
Factory "
{# $
public 
	interface	 
IAeronaveFactory #
{$ %
Aeronave 
Create 
( 
string 
codAeronave &
,& '
string( .
marca/ 4
,4 5
string6 <
modelo= C
,C D
intE H
nroasientosI T
,T U
decimalV ]
capacidadcarga^ l
,l m
decimaln u!
captanquecombustible	v ä
,
ä ã
string
å í(
aereopuertoEstacionamiento
ì ≠
)
≠ Æ
;
Æ Ø
} 
} »3
~C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\Aeronave.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
Model  
.  !
	Aeronaves! *
{+ ,
public 
class	 
Aeronave 
: 
AggregateRoot '
<' (
Guid( ,
>, -
{. /
public 

string 
prueba 
; 
public 

CodigoAeronaveValue 
CodAeronave *
;* +
public 

string 
Marca 
{ 
get 
; 
private &
set' *
;* +
}, -
public 

string 
Modelo 
{ 
get 
; 
private  '
set( +
;+ ,
}- .
public 

NroAsientosValue 
NroAsientos '
{( )
get* -
;- .
private/ 6
set7 :
;: ;
}< =
public 
 
RegistroDecimalValue 
CapacidadCarga  .
{/ 0
get1 4
;4 5
private6 =
set> A
;A B
}C D
public 
 
RegistroDecimalValue  
CapTanqueCombustible  4
{5 6
get7 :
;: ;
private< C
setD G
;G H
}I J
public 

string &
AereopuertoEstacionamiento ,
{- .
get/ 2
;2 3
private4 ;
set< ?
;? @
}A B
public 

string 
EstadoAeronave  
{! "
get# &
;& '
private( /
set0 3
;3 4
}5 6
private 
readonly 
ICollection  
<  !
AeronaveAsientos! 1
>1 2
AsientosAeronave3 C
;C D
public 

IReadOnlyCollection 
< 
AeronaveAsientos /
>/ 0
DetalleAsientos1 @
{A B
get   	
{  
 
return!! 
new!! 
ReadOnlyCollection!! %
<!!% &
AeronaveAsientos!!& 6
>!!6 7
(!!7 8
AsientosAeronave!!8 H
.!!H I
ToList!!I O
(!!O P
)!!P Q
)!!Q R
;!!R S
}"" 
}## 
public&& 

Aeronave&& 
(&& 
string&& 
codAeronave&& &
,&&& '
string&&( .
marca&&/ 4
,&&4 5
string&&6 <
modelo&&= C
,&&C D
int&&E H
nroasientos&&I T
,&&T U
decimal&&V ]
capacidadcarga&&^ l
,&&l m
decimal&&n u!
captanquecombustible	&&v ä
,
&&ä ã
string
&&å í(
aereopuertoEstacionamiento
&&ì ≠
)
&&≠ Æ
{
&&Ø ∞
Id'' 
=''	 

Guid'' 
.'' 
NewGuid'' 
('' 
)'' 
;'' 
CodAeronave(( 
=(( 
codAeronave(( 
;((  
Marca)) 
=)) 
marca)) 
;)) 
Modelo** 
=** 
modelo** 
;** 
NroAsientos++ 
=++ 
nroasientos++ 
;++  
CapacidadCarga,, 
=,, 
capacidadcarga,, %
;,,% & 
CapTanqueCombustible-- 
=--  
captanquecombustible-- 1
;--1 2&
AereopuertoEstacionamiento..  
=..! "&
aereopuertoEstacionamiento..# =
;..= >
EstadoAeronave// 
=// 
$str// "
;//" #
AsientosAeronave00 
=00 
new00 
List00 !
<00! "
AeronaveAsientos00" 2
>002 3
(003 4
)004 5
;005 6
}11 
public44 

Aeronave44 
(44 
)44 
{44 
}44 
public77 

void77 $
ActualizarEstadoAeronave77 (
(77( )
)77) *
{77+ ,
EstadoAeronave88 
=88 
$str88 !
;88! "
}99 
public;; 

void;; 1
%ActualizarEstadoMantenimientoAeronave;; 5
(;;5 6
);;6 7
{;;8 9
EstadoAeronave<< 
=<< 
$str<< &
;<<& '
}== 
public@@ 

void@@ 
AgregarAsiento@@ 
(@@ 
Guid@@ #

aeronaveId@@$ .
,@@. /
string@@0 6
asientosClases@@7 E
,@@E F
string@@G M
asientosUbicacion@@N _
,@@_ `
int@@a d
nrosilla@@e m
,@@m n
string@@o u
estadoAsiento	@@v É
)
@@É Ñ
{
@@Ö Ü
varAA 	
detalleAsientoAA
 
=AA 
newAA 
AeronaveAsientosAA /
(AA/ 0

aeronaveIdAA0 :
,AA: ;
asientosClasesAA< J
,AAJ K
asientosUbicacionAAL ]
,AA] ^
nrosillaAA_ g
,AAg h
estadoAsientoAAi v
)AAv w
;AAw x
AsientosAeronaveBB 
.BB 
AddBB 
(BB 
detalleAsientoBB )
)BB) *
;BB* +
AddDomainEventDD 
(DD 
newDD 
AsientoAgregadoDD (
(DD( )

aeronaveIdDD) 3
,DD3 4
asientosClasesDD5 C
,DDC D
asientosUbicacionDDE V
,DDV W
nrosillaDDX `
,DD` a
estadoAsientoDDb o
)DDo p
)DDp q
;DDq r
}EE 
publicHH 

voidHH 
RegistroAeronaveHH  
(HH  !
)HH! "
{HH# $
EstadoAeronaveJJ 
=JJ 
$strJJ "
;JJ" #
AddDomainEventKK 
(KK 
newKK 
AeronaveAgregadaKK )
(KK) *
IdKK* ,
,KK, -
CodAeronaveKK. 9
,KK9 :
MarcaKK; @
,KK@ A
ModeloKKB H
,KKH I
NroAsientosKKJ U
,KKU V
CapacidadCargaKKW e
,KKe f 
CapTanqueCombustibleKKg {
,KK{ |'
AereopuertoEstacionamiento	KK} ó
)
KKó ò
)
KKò ô
;
KKô ö
}LL 
}NN 
}OO ˝
ÜC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\AeronaveAsientos.cs
	namespace

 	
	Aeronaves


 
.

 
Domain

 
.

 
Model

  
.

  !
	Aeronaves

! *
{

+ ,
public 
class	 
AeronaveAsientos 
:  !
Entity" (
<( )
Guid) -
>- .
{/ 0
public 

Guid 

AeronaveId 
{ 
get  
;  !
private" )
set* -
;- .
}/ 0
public 

string 
ClaseAsiento 
{  
get! $
;$ %
private& -
set. 1
;1 2
}3 4
public 

string 
	Ubicacion 
{ 
get !
;! "
private# *
set+ .
;. /
}0 1
public 

int 
NroSilla 
{ 
get 
; 
private &
set' *
;* +
}, -
public 

string 
EstadoAsiento 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 

AeronaveAsientos 
( 
) 
{ 
}  !
public 

AeronaveAsientos 
( 
Guid  

aeronaveId! +
,+ ,
string- 3
asientosClases4 B
,B C
stringD J
asientosUbicacionK \
,\ ]
int^ a
nrosillab j
,j k
stringl r
estadoAsiento	s Ä
)
Ä Å
{
Ç É
Id 
=	 

Guid 
. 
NewGuid 
( 
) 
; 

AeronaveId 
= 

aeronaveId 
; 
ClaseAsiento 
= 
asientosClases #
;# $
	Ubicacion 
= 
asientosUbicacion #
;# $
NroSilla 
= 
nrosilla 
; 
EstadoAsiento 
= 
estadoAsiento #
;# $
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

void %
ModificarAeronaveAsientos )
() *
string* 0
asientosClases1 ?
,? @
stringA G
asientosUbicacionH Y
,Y Z
int[ ^
nrosilla_ g
,g h
stringi o
estadoAsientop }
)} ~
{	 Ä
ClaseAsiento   
=   
asientosClases   #
;  # $
	Ubicacion!! 
=!! 
asientosUbicacion!! #
;!!# $
NroSilla"" 
="" 
nrosilla"" 
;"" 
EstadoAsiento## 
=## 
estadoAsiento## #
;### $
}$$ 
}%% 
}&& Ü
õC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\ValueObjects\AeronaveEstadoAsignacion.cs
	namespace		 	
	Aeronaves		
 
.		 
Domain		 
.		 
Model		  
.		  !
	Aeronaves		! *
.		* +
ValueObjects		+ 7
{		8 9
public

 
record

	 $
AeronaveEstadoAsignacion

 (
:

) *
ValueObject

+ 6
{

7 8
public 

string 
Value 
{ 
get 
; 
}  
public 
$
AeronaveEstadoAsignacion #
(# $
string$ *
value+ 0
)0 1
{2 3
if 
(	 

value
 
is 
null 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 X
)X Y
;Y Z
} 
else 
if 
( 
value 
!= 
$str $
&&% '
value( -
!=. 0
$str1 <
)< =
{> ?
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 c
)c d
;d e
} 
Value 
= 
value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #
string$ *
(* +$
AeronaveEstadoAsignacion+ C
valueD I
)I J
{K L
return 
value 
. 
Value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #$
AeronaveEstadoAsignacion$ <
(< =
string= C
valueD I
)I J
{K L
return 
new $
AeronaveEstadoAsignacion )
() *
value* /
)/ 0
;0 1
} 
} 
}   û
üC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\ValueObjects\AeronaveEstadoDisponibilidad.cs
	namespace		 	
	Aeronaves		
 
.		 
Domain		 
.		 
Model		  
.		  !
	Aeronaves		! *
.		* +
ValueObjects		+ 7
{		8 9
public 
record	 (
AeronaveEstadoDisponibilidad ,
:- .
ValueObject/ :
{; <
public 

string 
Value 
{ 
get 
; 
}  
public 
(
AeronaveEstadoDisponibilidad '
(' (
string( .
value/ 4
)4 5
{6 7
if 
(	 

value
 
is 
null 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 X
)X Y
;Y Z
} 
else 
if 
( 
value 
!= 
$str &
&&' )
value* /
!=0 2
$str3 =
)= >
{? @
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 d
)d e
;e f
} 
Value 
= 
value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #
string$ *
(* +(
AeronaveEstadoDisponibilidad+ G
valueH M
)M N
{O P
return 
value 
. 
Value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #(
AeronaveEstadoDisponibilidad$ @
(@ A
stringA G
valueH M
)M N
{O P
return 
new (
AeronaveEstadoDisponibilidad -
(- .
value. 3
)3 4
;4 5
}   
}!! 
}"" ï
íC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\ValueObjects\AeronaveEstados.cs
	namespace

 	
	Aeronaves


 
.

 
Domain

 
.

 
Model

  
.

  !
	Aeronaves

! *
.

* +
ValueObjects

+ 7
{

8 9
public 
record	 
AeronaveEstados 
:  !
ValueObject" -
{. /
public 

string 
Value 
{ 
get 
; 
}  
public 

AeronaveEstados 
( 
string !
value" '
)' (
{) *
if 
(	 

value
 
is 
null 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 X
)X Y
;Y Z
} 
else 
if 
( 
value 
!= 
$str %
&&& (
value) .
!=/ 1
$str2 A
&&B D
valueE J
!=K M
$strN X
)X Y
{Z [
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 q
)q r
;r s
} 
Value 
= 
value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #
string$ *
(* +
AeronaveEstados+ :
value; @
)@ A
{B C
return 
value 
. 
Value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #
AeronaveEstados$ 3
(3 4
string4 :
value; @
)@ A
{B C
return 
new 
AeronaveEstados  
(  !
value! &
)& '
;' (
} 
} 
}   à
òC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\ValueObjects\CapacidadDecimalValue.cs
	namespace		 	
	Aeronaves		
 
.		 
Domain		 
.		 
Model		  
.		  !
	Aeronaves		! *
.		* +
ValueObjects		+ 7
{		8 9
public

 
record

	 !
CapacidadDecimalValue

 %
{

& '
public 

decimal 
Value 
{ 
get 
; 
init  $
;$ %
}& '
public 
!
CapacidadDecimalValue  
(  !
decimal! (
value) .
). /
{0 1
if 
(	 

value
 
<= 
$num 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 b
)b c
;c d
} 
Value 
= 
value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #
decimal$ +
(+ ,!
CapacidadDecimalValue, A
valueB G
)G H
{I J
return 
value 
. 
Value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #!
CapacidadDecimalValue$ 9
(9 :
decimal: A
valueB G
)G H
{I J
return 
new !
CapacidadDecimalValue &
(& '
value' ,
), -
;- .
} 
} 
} —
ëC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\ValueObjects\CapacidadValue.cs
	namespace

 	
	Aeronaves


 
.

 
Domain

 
.

 
ValueObjects

 '
{

( )
public 
record	 
CapacidadValue 
:  
ValueObject! ,
{- .
public 

int 
Value 
{ 
get 
; 
init  
;  !
}" #
public 

CapacidadValue 
( 
int 
value #
)# $
{% &
if 
(	 

value
 
<= 
$num 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 j
)j k
;k l
} 
else 

if 
( 
value 
> 
$num 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 k
)k l
;l m
} 
Value 
= 
value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #
int$ '
(' (
CapacidadValue( 6
value7 <
)< =
{> ?
return 
value 
. 
Value 
; 
} 
[!! #
ExcludeFromCodeCoverage!! 
]!! 
public"" 

static"" 
implicit"" 
operator"" #
CapacidadValue""$ 2
(""2 3
int""3 6
value""7 <
)""< =
{""> ?
return## 
new## 
CapacidadValue## 
(##  
value##  %
)##% &
;##& '
}$$ 
}%% 
}&& ›
ñC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\ValueObjects\CodigoAeronaveValue.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
Model  
.  !
	Aeronaves! *
.* +
ValueObjects+ 7
{8 9
public

 
record

	 
CodigoAeronaveValue

 #
:

$ %
ValueObject

& 1
{

2 3
public 

string 
Value 
{ 
get 
; 
}  
public 

CodigoAeronaveValue 
( 
string %
value& +
)+ ,
{- .
	CheckRule 
( 
new 
ShareKernel 
.  
Rules  %
.% &$
StringNotNullOrEmptyRule& >
(> ?
value? D
)D E
)E F
;F G
Value 
= 
value 
; 
} 
public 

static 
implicit 
operator #
string$ *
(* +
CodigoAeronaveValue+ >
value? D
)D E
{F G
return 
value 
. 
Value 
; 
} 
public 

static 
implicit 
operator #
CodigoAeronaveValue$ 7
(7 8
string8 >
value? D
)D E
{F G
return 
new 
CodigoAeronaveValue $
($ %
value% *
)* +
;+ ,
} 
} 
}!! €
ìC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Aeronaves\ValueObjects\NroAsientosValue.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
Model  
.  !
	Aeronaves! *
.* +
ValueObjects+ 7
{8 9
public

 
record

	 
NroAsientosValue

  
:

! "
ValueObject

# .
{

/ 0
public 

int 
Value 
{ 
get 
; 
} 
public 

NroAsientosValue 
( 
int 
value  %
)% &
{' (
if 
(	 

value
 
<= 
$num 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 a
)a b
;b c
} 
Value 
= 
value 
; 
} 
public 

static 
implicit 
operator #
int$ '
(' (
NroAsientosValue( 8
value9 >
)> ?
{@ A
return 
value 
. 
Value 
; 
} 
public 

static 
implicit 
operator #
NroAsientosValue$ 4
(4 5
int5 8
value9 >
)> ?
{@ A
return 
new 
NroAsientosValue !
(! "
value" '
)' (
;( )
} 
} 
} „
vC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Enum\Enums.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
Model  
.  !
Enum! %
{& '
public 
class	 
Enums 
{ 
public		 

enum		 
AeronaveStatus		 
{		  
	Operativo

 
,

 
Mantenimiento 
, 
Asignado 
} 
public 

enum 
AsientosClases 
{  
	Economica 
, 
PrimeraClase 
, 
	Ejecutiva 
} 
public 

enum 
AsientosUbicacion !
{" #
Ventana 
, 
Central 
, 
Pasillo 
} 
public 

enum 
AsientosStatus 
{  
	Reservado 
, 
Libre 
} 
} 
}   ˇ
}C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Model\Personal\Personal.cs
	namespace

 	
	Aeronaves


 
.

 
Domain

 
.

 
Model

  
.

  !
Personal

! )
{

* +
public 
class	 
Personal 
: 
AggregateRoot '
<' (
Guid( ,
>, -
{. /
public 

PersonNameValue 
NombreCompleto )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 

Personal 
( 
string 
nombreCompleto )
)) *
{+ ,
Id 
=	 

Guid 
. 
NewGuid 
( 
) 
; 
NombreCompleto 
= 
nombreCompleto %
;% &
} 
} 
} ∫
ÜC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Repositories\IAeronaveRepository.cs
	namespace

 	
	Aeronaves


 
.

 
Domain

 
.

 
Repositories

 '
{

( )
public 
	interface	 
IAeronaveRepository &
:' (
IRepository) 4
<4 5
Aeronave5 =
,= >
Guid? C
>C D
{E F
Task 
UpdateAsync	 
( 
Aeronave 
obj !
)! "
;" #
Task 
< 	
List	 
< 
Aeronave 
> 
> 
GetAll 
(  
)  !
;! "
} 
} …
~C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\Repositories\IUnitOfWork.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
Repositories '
{( )
public 
	interface	 
IUnitOfWork 
{  
Task		 
Commit			 
(		 
)		 
;		 
}

 
} ˜
ÄC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\ValueObjects\CantidadValue.cs
	namespace

 	
	Aeronaves


 
.

 
Domain

 
.

 
ValueObjects

 '
{

( )
public 
record	 
CantidadValue 
: 
ValueObject  +
{, -
public 

int 
Value 
{ 
get 
; 
} 
public 

CantidadValue 
( 
int 
value "
)" #
{$ %
if 
(	 

value
 
<= 
$num 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 ]
)] ^
;^ _
} 
Value 
= 
value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #
int$ '
(' (
CantidadValue( 5
value6 ;
); <
{= >
return 
value 
. 
Value 
; 
} 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
implicit 
operator #
CantidadValue$ 1
(1 2
int2 5
value6 ;
); <
{= >
return 
new 
CantidadValue 
( 
value $
)$ %
;% &
} 
} 
} Ç
áC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronaves.Domain\ValueObjects\RegistroDecimalValue.cs
	namespace 	
	Aeronaves
 
. 
Domain 
. 
ValueObjects '
{( )
public

 
record

	  
RegistroDecimalValue

 $
{

% &
public 

decimal 
Value 
{ 
get 
; 
}  !
public 
 
RegistroDecimalValue 
(  
decimal  '
value( -
)- .
{/ 0
if 
(	 

value
 
< 
$num 
) 
{ 
throw 
new ,
 BussinessRuleValidationException 2
(2 3
$str3 `
)` a
;a b
} 
Value 
= 
value 
; 
} 
public 

static 
implicit 
operator #
decimal$ +
(+ , 
RegistroDecimalValue, @
valueA F
)F G
{H I
return 
value 
. 
Value 
; 
} 
public 

static 
implicit 
operator # 
RegistroDecimalValue$ 8
(8 9
decimal9 @
valueA F
)F G
{H I
return 
new  
RegistroDecimalValue %
(% &
value& +
)+ ,
;, -
} 
} 
} 