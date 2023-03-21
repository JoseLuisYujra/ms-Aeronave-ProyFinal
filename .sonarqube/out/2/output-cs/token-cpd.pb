ï5
ïC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\Config\ReadConfig\AeronaveReadConfig.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '
Config' -
.- .

ReadConfig. 8
{9 :
public 
class	 
AeronaveReadConfig !
:" #$
IEntityTypeConfiguration$ <
<< =
AeronaveReadModel= N
>N O
,O P$
IEntityTypeConfiguration$ <
<< =%
AeronaveAsientosReadModel= V
>V W
{X Y
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
AeronaveReadModel, =
>= >
builder? F
)F G
{H I
builder 
. 
ToTable 
( 
$str  
)  !
;! "
builder 
. 
HasKey 
( 
x 
=> 
x 
. 
Id 
) 
;  
builder 
. 
Property 
( 
x 
=> 
x 
. 
CodAeronave )
)) *
.
 
HasColumnName 
( 
$str &
)& '
.
 
HasMaxLength 
( 
$num 
) 
; 
builder 
. 
Property 
( 
x 
=> 
x 
. 
Marca #
)# $
.
 
HasColumnName 
( 
$str  
)  !
.
 
HasMaxLength 
( 
$num 
) 
; 
builder 
. 
Property 
( 
x 
=> 
x 
. 
Modelo $
)$ %
.
 
HasColumnName 
( 
$str !
)! "
.
 
HasMaxLength 
( 
$num 
) 
; 
builder 
. 
Property 
( 
x 
=> 
x 
. 
NroAsientos )
)) *
.  	 

HasColumnName  
 
(   
$str   %
)  % &
.!!	 

HasColumnType!!
 
(!! 
$str!! 
)!! 
;!! 
builder## 
.## 
Property## 
(## 
x## 
=>## 
x## 
.## 
CapacidadCarga## ,
)##, -
.$$
 
HasColumnName$$ 
($$ 
$str$$ )
)$$) *
.%%
 
HasColumnType%% 
(%% 
$str%% "
)%%" #
.&&
 
HasPrecision&& 
(&& 
$num&& 
,&& 
$num&& 
)&& 
;&& 
builder(( 
.(( 
Property(( 
((( 
x(( 
=>(( 
x(( 
.((  
CapTanqueCombustible(( 2
)((2 3
.))	 

HasColumnName))
 
()) 
$str)) .
))). /
.**	 

HasColumnType**
 
(** 
$str** !
)**! "
.++	 

HasPrecision++
 
(++ 
$num++ 
,++ 
$num++ 
)++ 
;++ 
builder-- 
.-- 
Property-- 
(-- 
x-- 
=>-- 
x-- 
.-- &
AereopuertoEstacionamiento-- 8
)--8 9
...	 

HasColumnName..
 
(.. 
$str.. 4
)..4 5
.//	 

HasMaxLength//
 
(// 
$num// 
)// 
;// 
builder22 
.22 
Property22 
(22 
x22 
=>22 
x22 
.22 
EstadoAeronave22 ,
)22, -
.33 
HasColumnName33 
(33 
$str33 ,
)33, -
.44 
HasMaxLength44 
(44 
$num44 
)44 
;44 
builder66 
.66 
HasMany66 
(66 
x66 
=>66 
x66 
.66 
AsientosAeronave66 -
)66- .
.77 
WithOne77 
(77 
x77 
=>77 
x77 
.77 
Aeronave77 %
)77% &
;77& '
}88 
public:: 

void:: 
	Configure:: 
(:: 
EntityTypeBuilder:: +
<::+ ,%
AeronaveAsientosReadModel::, E
>::E F
builder::G N
)::N O
{::P Q
builder;; 
.;; 
ToTable;; 
(;; 
$str;; (
);;( )
;;;) *
builder<< 
.<< 
HasKey<< 
(<< 
x<< 
=><< 
x<< 
.<< 
Id<< 
)<< 
;<<  
builder>> 
.>> 
Property>> 
(>> 
x>> 
=>>> 
x>> 
.>> 
ClaseAsiento>> *
)>>* +
.??
 
HasColumnName?? 
(?? 
$str?? '
)??' (
.@@
 
HasMaxLength@@ 
(@@ 
$num@@ 
)@@ 
;@@ 
builderBB 
.BB 
PropertyBB 
(BB 
xBB 
=>BB 
xBB 
.BB 
	UbicacionBB '
)BB' (
.CC
 
HasColumnNameCC 
(CC 
$strCC $
)CC$ %
.DD
 
HasMaxLengthDD 
(DD 
$numDD 
)DD 
;DD 
builderGG 
.GG 
PropertyGG 
(GG 
xGG 
=>GG 
xGG 
.GG 
NroSillaGG &
)GG& '
.HH
 
HasColumnNameHH 
(HH 
$strHH #
)HH# $
.II
 
HasColumnTypeII 
(II 
$strII 
)II 
;II  
builderKK 
.KK 
PropertyKK 
(KK 
xKK 
=>KK 
xKK 
.KK 
EstadoAsientoKK +
)KK+ ,
.LL 	
HasColumnNameLL	 
(LL 
$strLL &
)LL& '
.MM 	
HasMaxLengthMM	 
(MM 
$numMM 
)MM 
;MM 
}NN 
}OO 
}PP  P
óC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\Config\WriteConfig\AeronaveWriteConfig.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '
Config' -
.- .
WriteConfig. 9
{: ;
public 
class	 
AeronaveWriteConfig "
:# $$
IEntityTypeConfiguration% =
<= >
Aeronave> F
>F G
,G H$
IEntityTypeConfigurationI a
<a b
AeronaveAsientosb r
>r s
{t u
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
Aeronave, 4
>4 5
builder6 =
)= >
{? @
builder 
. 
ToTable 
( 
$str  
)  !
;! "
builder 
. 
HasKey 
( 
x 
=> 
x 
. 
Id 
) 
;  
var 	 
codAeronaveConverter
 
=  
new! $
ValueConverter% 3
<3 4
CodigoAeronaveValue4 G
,G H
stringI O
>O P
(P Q
CodAeronaveValue
 
=> 
CodAeronaveValue .
.. /
Value/ 4
,4 5
CodAeronave
 
=> 
new 
CodigoAeronaveValue 0
(0 1
CodAeronave1 <
)< =
) 
; 
builder 
. 
Property 
( 
x 
=> 
x 
. 
CodAeronave )
)) *
.
 
HasConversion 
(  
codAeronaveConverter -
)- .
.
 
HasColumnName 
( 
$str &
)& '
.
 
HasMaxLength 
( 
$num 
) 
; 
builder   
.   
Property   
(   
x   
=>   
x   
.   
Marca   #
)  # $
.!! 
HasColumnName!! 
(!! 
$str!! #
)!!# $
."" 
HasColumnType"" 
("" 
$str"" $
)""$ %
.## 
HasMaxLength## 
(## 
$num## 
)## 
;## 
builder%% 
.%% 
Property%% 
(%% 
x%% 
=>%% 
x%% 
.%% 
Modelo%% $
)%%$ %
.&& 
HasColumnName&& 
(&& 
$str&& $
)&&$ %
.'' 
HasColumnType'' 
('' 
$str'' $
)''$ %
.(( 
HasMaxLength(( 
((( 
$num(( 
)(( 
;(( 
var** 	 
nroAsientosConverter**
 
=**  
new**! $
ValueConverter**% 3
<**3 4
NroAsientosValue**4 D
,**D E
int**F I
>**I J
(**J K
nroAsientosValue++
 
=>++ 
nroAsientosValue++ .
.++. /
Value++/ 4
,++4 5
nroAsientos,,
 
=>,, 
new,, 
NroAsientosValue,, -
(,,- .
nroAsientos,,. 9
),,9 :
),,: ;
;,,; <
builder-- 
.-- 
Property-- 
(-- 
x-- 
=>-- 
x-- 
.-- 
NroAsientos-- )
)--) *
... 
HasConversion.. 
(..  
nroAsientosConverter.. 0
)..0 1
.// 
HasColumnName// 
(// 
$str// )
)//) *
.00 
HasColumnType00 
(00 
$str00 !
)00! "
;00" #
var22 	#
CapacidadCargaConverter22
 !
=22" #
new22$ '
ValueConverter22( 6
<226 7 
RegistroDecimalValue227 K
,22K L
decimal22M T
>22T U
(22U V
CapacidadCargaValue33
 
=>33  
CapacidadCargaValue33! 4
.334 5
Value335 :
,33: ;
capacidadCarga44
 
=>44 
new44  
RegistroDecimalValue44  4
(444 5
capacidadCarga445 C
)44C D
)44D E
;44E F
builder55 
.55 
Property55 
(55 
x55 
=>55 
x55 
.55 
CapacidadCarga55 ,
)55, -
.66 
HasConversion66 
(66 #
CapacidadCargaConverter66 3
)663 4
.77 
HasColumnName77 
(77 
$str77 ,
)77, -
.88 
HasPrecision88 
(88 
$num88 
,88 
$num88  
)88  !
;88! "
var;; 	)
capTanqueCombustibleConverter;;
 '
=;;( )
new;;* -
ValueConverter;;. <
<;;< = 
RegistroDecimalValue;;= Q
,;;Q R
decimal;;S Z
>;;Z [
(;;[ \%
capTanqueCombustibleValue<<
 #
=><<$ &%
capTanqueCombustibleValue<<' @
.<<@ A
Value<<A F
,<<F G 
capTanqueCombustible==
 
=>== !
new==" % 
RegistroDecimalValue==& :
(==: ; 
capTanqueCombustible==; O
)==O P
)==P Q
;==Q R
builder>> 
.>> 
Property>> 
(>> 
x>> 
=>>> 
x>> 
.>>  
CapTanqueCombustible>> 2
)>>2 3
.?? 
HasConversion?? 
(?? )
capTanqueCombustibleConverter?? 9
)??9 :
.@@ 
HasColumnName@@ 
(@@ 
$str@@ 2
)@@2 3
.AA 
HasColumnTypeAA 
(AA 
$strAA %
)AA% &
.BB 
HasPrecisionBB 
(BB 
$numBB 
,BB 
$numBB  
)BB  !
;BB! "
builderDD 
.DD 
PropertyDD 
(DD 
xDD 
=>DD 
xDD 
.DD &
AereopuertoEstacionamientoDD 8
)DD8 9
.EE 
HasColumnNameEE 
(EE 
$strEE 7
)EE7 8
.FF 
HasColumnTypeFF 
(FF 
$strFF #
)FF# $
.GG 
HasMaxLengthGG 
(GG 
$numGG 
)GG 
;GG 
builderII 
.II 
PropertyII 
(II 
xII 
=>II 
xII 
.II 
EstadoAeronaveII ,
)II, -
.JJ 
HasColumnNameJJ 
(JJ 
$strJJ ,
)JJ, -
.KK 
HasColumnTypeKK 
(KK 
$strKK $
)KK$ %
.LL 
HasMaxLengthLL 
(LL 
$numLL 
)LL 
;LL 
builderNN 
.NN 
HasManyNN 
(NN 
typeofNN 
(NN 
AeronaveAsientosNN -
)NN- .
,NN. /
$strNN0 B
)NNB C
;NNC D
builderPP 
.PP 
IgnorePP 
(PP 
$strPP $
)PP$ %
;PP% &
builderQQ 
.QQ 
IgnoreQQ 
(QQ 
xQQ 
=>QQ 
xQQ 
.QQ 
DomainEventsQQ (
)QQ( )
;QQ) *
builderRR 
.RR 
IgnoreRR 
(RR 
xRR 
=>RR 
xRR 
.RR 
DetalleAsientosRR +
)RR+ ,
;RR, -
}TT 
publicVV 

voidVV 
	ConfigureVV 
(VV 
EntityTypeBuilderVV +
<VV+ ,
AeronaveAsientosVV, <
>VV< =
builderVV> E
)VVE F
{VVG H
builderXX 
.XX 
ToTableXX 
(XX 
$strXX (
)XX( )
;XX) *
builderYY 
.YY 
HasKeyYY 
(YY 
xYY 
=>YY 
xYY 
.YY 
IdYY 
)YY 
;YY  
builder\\ 
.\\ 
Property\\ 
(\\ 
x\\ 
=>\\ 
x\\ 
.\\ 
ClaseAsiento\\ *
)\\* +
.]]
 
HasColumnName]] 
(]] 
$str]] '
)]]' (
.^^
 
HasMaxLength^^ 
(^^ 
$num^^ 
)^^ 
;^^ 
builder`` 
.`` 
Property`` 
(`` 
x`` 
=>`` 
x`` 
.`` 
	Ubicacion`` '
)``' (
.aa
 
HasColumnNameaa 
(aa 
$straa $
)aa$ %
.bb
 
HasMaxLengthbb 
(bb 
$numbb 
)bb 
;bb 
builderdd 
.dd 
Propertydd 
(dd 
xdd 
=>dd 
xdd 
.dd 
NroSilladd &
)dd& '
.ee
 
HasColumnNameee 
(ee 
$stree #
)ee# $
.ff
 
HasColumnTypeff 
(ff 
$strff 
)ff 
;ff  
builderhh 
.hh 
Propertyhh 
(hh 
xhh 
=>hh 
xhh 
.hh 
EstadoAsientohh +
)hh+ ,
.ii 	
HasColumnNameii	 
(ii 
$strii &
)ii& '
.jj 	
HasMaxLengthjj	 
(jj 
$numjj 
)jj 
;jj 
builderll 
.ll 
Ignorell 
(ll 
$strll $
)ll$ %
;ll% &
buildermm 
.mm 
Ignoremm 
(mm 
xmm 
=>mm 
xmm 
.mm 
DomainEventsmm (
)mm( )
;mm) *
}nn 
}oo 
}pp ä
ÜC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\Context\ReadDbContext.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '
Context' .
{/ 0
public 
class	 
ReadDbContext 
: 
	DbContext (
{) *
public 

virtual 
DbSet 
< 
AeronaveReadModel *
>* +
Aeronave, 4
{5 6
set7 :
;: ;
get< ?
;? @
}A B
public 

ReadDbContext 
( 
DbContextOptions )
<) *
ReadDbContext* 7
>7 8
options9 @
)@ A
:B C
baseD H
(H I
optionsI P
)P Q
{R S
} 
	protected 
override 
void 
OnModelCreating +
(+ ,
ModelBuilder, 8
modelBuilder9 E
)E F
{G H
base 

.
 
OnModelCreating 
( 
modelBuilder '
)' (
;( )
var 	
aeronaveConfig
 
= 
new 
AeronaveReadConfig 1
(1 2
)2 3
;3 4
modelBuilder 
. 
ApplyConfiguration %
<% &
AeronaveReadModel& 7
>7 8
(8 9
aeronaveConfig9 G
)G H
;H I
modelBuilder 
. 
ApplyConfiguration %
<% &%
AeronaveAsientosReadModel& ?
>? @
(@ A
aeronaveConfigA O
)O P
;P Q
modelBuilder 
. 
Ignore 
< 
DomainEvent %
>% &
(& '
)' (
;( )
modelBuilder 
. 
Ignore 
< 
AeronaveAgregada *
>* +
(+ ,
), -
;- .
modelBuilder 
. 
Ignore 
< %
AeronaveEstadoActualizado 3
>3 4
(4 5
)5 6
;6 7
modelBuilder 
. 
Ignore 
< 
AsientoAgregado )
>) *
(* +
)+ ,
;, -
}   
}!! 
}"" Ù
áC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\Context\WriteDbContext.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '
Context' .
{/ 0
public 
class	 
WriteDbContext 
: 
	DbContext  )
{* +
public 

virtual 
DbSet 
< 
Aeronave !
>! "
Aeronave# +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 

WriteDbContext 
( 
DbContextOptions *
<* +
WriteDbContext+ 9
>9 :
options; B
)B C
:D E
baseF J
(J K
optionsK R
)R S
{T U
} 
	protected 
override 
void 
OnModelCreating +
(+ ,
ModelBuilder, 8
modelBuilder9 E
)E F
{G H
base 

.
 
OnModelCreating 
( 
modelBuilder '
)' (
;( )
var 	
aeronaveConfig
 
= 
new 
AeronaveWriteConfig 2
(2 3
)3 4
;4 5
modelBuilder 
. 
ApplyConfiguration %
<% &
Aeronave& .
>. /
(/ 0
aeronaveConfig0 >
)> ?
;? @
modelBuilder 
. 
ApplyConfiguration %
<% &
AeronaveAsientos& 6
>6 7
(7 8
aeronaveConfig8 F
)F G
;G H
modelBuilder 
. 
Ignore 
< 
DomainEvent %
>% &
(& '
)' (
;( )
modelBuilder 
. 
Ignore 
< 
AeronaveAgregada *
>* +
(+ ,
), -
;- .
modelBuilder 
. 
Ignore 
< %
AeronaveEstadoActualizado 3
>3 4
(4 5
)5 6
;6 7
modelBuilder 
. 
Ignore 
< 
AsientoAgregado )
>) *
(* +
)+ ,
;, -
} 
} 
}   ÔD
õC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\Migrations\20221003000726_InitialStructure.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '

Migrations' 1
{2 3
public 
partial	 
class 
InitialStructure '
:( )
	Migration* 3
{4 5
	protected 
override 
void 
Up 
( 
MigrationBuilder /
migrationBuilder0 @
)@ A
{B C
migrationBuilder 
. 
CreateTable "
(" #
name
 
: 
$str 
, 
columns		
 
:		 
table		 
=>		 
new		 
{		  !
Id

 
=

 
table

 
.

 
Column

 
<

 
Guid

 "
>

" #
(

# $
type

$ (
:

( )
$str

* <
,

< =
nullable

> F
:

F G
false

H M
)

M N
,

N O
CodAeronave 
= 
table 
.  
Column  &
<& '
string' -
>- .
(. /
type/ 3
:3 4
$str5 C
,C D
	maxLengthE N
:N O
$numP R
,R S
nullableT \
:\ ]
true^ b
)b c
,c d
Marca 
= 
table 
. 
Column  
<  !
string! '
>' (
(( )
type) -
:- .
$str/ =
,= >
	maxLength? H
:H I
$numJ L
,L M
nullableN V
:V W
trueX \
)\ ]
,] ^
Modelo 
= 
table 
. 
Column !
<! "
string" (
>( )
() *
type* .
:. /
$str0 >
,> ?
	maxLength@ I
:I J
$numK M
,M N
nullableO W
:W X
trueY ]
)] ^
,^ _
NroAsientos 
= 
table 
.  
Column  &
<& '
int' *
>* +
(+ ,
type, 0
:0 1
$str2 7
,7 8
nullable9 A
:A B
falseC H
)H I
,I J
CapacidadCarga 
= 
table "
." #
Column# )
<) *
decimal* 1
>1 2
(2 3
type3 7
:7 8
$str9 H
,H I
	precisionJ S
:S T
$numU W
,W X
scaleY ^
:^ _
$num` a
,a b
nullablec k
:k l
falsem r
)r s
,s t 
CapTanqueCombustible  
=! "
table# (
.( )
Column) /
</ 0
decimal0 7
>7 8
(8 9
type9 =
:= >
$str? N
,N O
	precisionP Y
:Y Z
$num[ ]
,] ^
scale_ d
:d e
$numf g
,g h
nullablei q
:q r
falses x
)x y
,y z&
AereopuertoEstacionamiento &
=' (
table) .
.. /
Column/ 5
<5 6
string6 <
>< =
(= >
type> B
:B C
$strD R
,R S
	maxLengthT ]
:] ^
$num_ a
,a b
nullablec k
:k l
truem q
)q r
,r s
EstadoAeronave 
= 
table "
." #
Column# )
<) *
string* 0
>0 1
(1 2
type2 6
:6 7
$str8 F
,F G
	maxLengthH Q
:Q R
$numS U
,U V
nullableW _
:_ `
truea e
)e f
}
 
, 
constraints
 
: 
table 
=> 
{  !
table 
. 

PrimaryKey 
( 
$str *
,* +
x, -
=>. 0
x1 2
.2 3
Id3 5
)5 6
;6 7
}
 
) 
; 
migrationBuilder 
. 
CreateTable "
(" #
name
 
: 
$str "
," #
columns
 
: 
table 
=> 
new 
{  !
Id 
= 
table 
. 
Column 
< 
Guid "
>" #
(# $
type$ (
:( )
$str* <
,< =
nullable> F
:F G
falseH M
)M N
,N O

AeronaveId 
= 
table 
. 
Column %
<% &
Guid& *
>* +
(+ ,
type, 0
:0 1
$str2 D
,D E
nullableF N
:N O
falseP U
)U V
,V W
ClaseAsiento 
= 
table  
.  !
Column! '
<' (
string( .
>. /
(/ 0
type0 4
:4 5
$str6 D
,D E
	maxLengthF O
:O P
$numQ S
,S T
nullableU ]
:] ^
true_ c
)c d
,d e
	Ubicacion 
= 
table 
. 
Column $
<$ %
string% +
>+ ,
(, -
type- 1
:1 2
$str3 A
,A B
	maxLengthC L
:L M
$numN P
,P Q
nullableR Z
:Z [
true\ `
)` a
,a b
NroSilla 
= 
table 
. 
Column #
<# $
int$ '
>' (
(( )
type) -
:- .
$str/ 4
,4 5
nullable6 >
:> ?
false@ E
)E F
,F G
EstadoAsiento   
=   
table   !
.  ! "
Column  " (
<  ( )
string  ) /
>  / 0
(  0 1
type  1 5
:  5 6
$str  7 E
,  E F
	maxLength  G P
:  P Q
$num  R T
,  T U
nullable  V ^
:  ^ _
true  ` d
)  d e
}!!
 
,!! 
constraints""
 
:"" 
table"" 
=>"" 
{""  !
table## 
.## 

PrimaryKey## 
(## 
$str## 2
,##2 3
x##4 5
=>##6 8
x##9 :
.##: ;
Id##; =
)##= >
;##> ?
table$$ 
.$$ 

ForeignKey$$ 
($$ 
name%% 
:%% 
$str%% E
,%%E F
column&& 
:&& 
x&& 
=>&&  "
x&&# $
.&&$ %

AeronaveId&&% /
,&&/ 0
principalTable'' $
:''$ %
$str''& 0
,''0 1
principalColumn(( %
:((% &
$str((' +
,((+ ,
onDelete)) 
:)) 
ReferentialAction))  1
.))1 2
Cascade))2 9
)))9 :
;)): ;
}**
 
)** 
;** 
migrationBuilder,, 
.,, 
CreateIndex,, "
(,," #
name--
 
:-- 
$str-- 0
,--0 1
table..
 
:.. 
$str.. #
,..# $
column//
 
:// 
$str// 
)// 
;//  
}00 
	protected22 
override22 
void22 
Down22  
(22  !
MigrationBuilder22! 1
migrationBuilder222 B
)22B C
{22D E
migrationBuilder33 
.33 
	DropTable33  
(33  !
name44
 
:44 
$str44 "
)44" #
;44# $
migrationBuilder66 
.66 
	DropTable66  
(66  !
name77
 
:77 
$str77 
)77 
;77 
}88 
}99 
}:: ä
îC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\ReadModel\AeronaveAsientosReadModel.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '
	ReadModel' 0
{1 2
public 
class	 %
AeronaveAsientosReadModel (
{) *
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
}, -
public 

AeronaveReadModel 
Aeronave %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
} ±
åC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\ReadModel\AeronaveReadModel.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '
	ReadModel' 0
{1 2
public		 
class			 
AeronaveReadModel		  
{		! "
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
public 

string 
CodAeronave 
{ 
get  #
;# $
set% (
;( )
}* +
public 

string 
Marca 
{ 
get 
; 
set "
;" #
}$ %
public 

string 
Modelo 
{ 
get 
; 
set  #
;# $
}% &
public 

int 
NroAsientos 
{ 
get  
;  !
set" %
;% &
}' (
public 

decimal 
CapacidadCarga !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 

decimal  
CapTanqueCombustible '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 

string &
AereopuertoEstacionamiento ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 

string 
EstadoAeronave  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

List 
< %
AeronaveAsientosReadModel )
>) *
AsientosAeronave+ ;
{< =
get> A
;A B
setC F
;F G
}H I
} 
} ÷
éC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\Repository\AeronaveRepository.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '

Repository' 1
{2 3
public 
class	 
AeronaveRepository !
:" #
IAeronaveRepository$ 7
{8 9
public 

readonly 
DbSet 
< 
Aeronave "
>" #
	_aeronave$ -
;- .
public 

AeronaveRepository 
( 
WriteDbContext ,
context- 4
)4 5
{6 7
	_aeronave 
= 
context 
. 
Aeronave "
;" #
} 
public 

async 
Task 
CreateAsync !
(! "
Aeronave" *
obj+ .
). /
{0 1
await 
	_aeronave 
. 
AddAsync 
( 
obj "
)" #
;# $
} 
public 

async 
Task 
< 
Aeronave 
> 
FindByIdAsync  -
(- .
Guid. 2
id3 5
)5 6
{7 8
return 
await 
	_aeronave 
. 
SingleAsync (
(( )
x) *
=>+ -
x. /
./ 0
Id0 2
==3 5
id6 8
)8 9
;9 :
} 
public 

Task 
UpdateAsync 
( 
Aeronave $
obj% (
)( )
{* +
	_aeronave   
.   
Update   
(   
obj   
)   
;   
return"" 
Task"" 
."" 
CompletedTask"" 
;""  
}## 
public%% 

Task%% 
<%% 
List%% 
<%% 
Aeronave%% 
>%% 
>%% 
GetAll%%  &
(%%& '
)%%' (
{%%) *
return&& 
	_aeronave&& 
.&& 
Include&& 
(&& 
$str&& 1
)&&1 2
.&&2 3
ToListAsync&&3 >
(&&> ?
)&&? @
;&&@ A
}'' 
})) 
}** ™
{C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\UnitOfWork.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
{' (
public 
class	 

UnitOfWork 
: 
IUnitOfWork '
{( )
private 
readonly 
WriteDbContext #
_context$ ,
;, -
private 
readonly 
	IMediator 
	_mediator (
;( )
public 


UnitOfWork 
( 
WriteDbContext $
context% ,
,, -
	IMediator. 7
mediator8 @
)@ A
{B C
_context 
= 
context 
; 
	_mediator 
= 
mediator 
; 
} 
public 

async 
Task 
Commit 
( 
) 
{  
var 	
domainEvents
 
= 
_context !
.! "
ChangeTracker" /
./ 0
Entries0 7
<7 8
Entity8 >
<> ?
Guid? C
>C D
>D E
(E F
)F G
.
 
Select 
( 
x 
=> 
x 
. 
Entity 
.  
DomainEvents  ,
), -
.
 

SelectMany 
( 
x 
=> 
x 
) 
.
 
ToArray 
( 
) 
; 
foreach 
( 
var 
@event 
in 
domainEvents )
)) *
{+ ,
await 
	_mediator 
. 
Publish 
(  
@event  &
)& '
;' (
} 
await!! 
_context!! 
.!! 
SaveChangesAsync!! %
(!!% &
)!!& '
;!!' (
}## 
}$$ 
}'' ¨
†C:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\EF\UseCases\Queries\Aeronave\SearchAeronaveHandler.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
EF$ &
.& '
UseCases' /
./ 0
Queries0 7
.7 8
Aeronave8 @
{A B
public 
class	 !
SearchAeronaveHandler $
:% &
IRequestHandler' 6
<6 7
SearchAeronaveQuery7 J
,J K
AeronaveDTOL W
>W X
{Y Z
private 
readonly 
DbSet 
< 
AeronaveReadModel ,
>, -
_context. 6
;6 7
public 
!
SearchAeronaveHandler  
(  !
ReadDbContext! .
context/ 6
)6 7
{8 9
_context 
= 
context 
. 
Aeronave !
;! "
} 
public 

async 
Task 
< 
AeronaveDTO !
>! "
Handle# )
() *
SearchAeronaveQuery* =
request> E
,E F
CancellationTokenG X
cancellationTokenY j
)j k
{l m
AeronaveDTO 
result 
= 
null 
;  
var 	
AeronaveList
 
= 
await 
_context '
.' (
	FindAsync( 1
(1 2
request2 9
.9 :
Id: <
)< =
;= >
if 
(	 

AeronaveList
 
== 
null 
) 
{  !
return 
null 
; 
}   
result!! 
=!! 
new!! 
AeronaveDTO!! 
(!! 
)!!  
{!!! "
Id"" 

="" 
AeronaveList"" 
."" 
Id"" 
,"" 
CodAeronave## 
=## 
AeronaveList## "
.##" #
CodAeronave### .
,##. /
Marca$$ 
=$$ 
AeronaveList$$ 
.$$ 
Marca$$ "
,$$" #
Modelo%% 
=%% 
AeronaveList%% 
.%% 
Modelo%% $
,%%$ %
NroAsientos&& 
=&& 
AeronaveList&& "
.&&" #
NroAsientos&&# .
,&&. /
CapacidadCarga'' 
='' 
AeronaveList'' %
.''% &
CapacidadCarga''& 4
,''4 5 
CapTanqueCombustible(( 
=(( 
AeronaveList(( +
.((+ , 
CapTanqueCombustible((, @
,((@ A&
AereopuertoEstacionamiento)) "
=))# $
AeronaveList))% 1
.))1 2&
AereopuertoEstacionamiento))2 L
,))L M
EstadoAeronave** 
=** 
AeronaveList** %
.**% &
EstadoAeronave**& 4
}++ 
;++ 
return-- 
result-- 
;-- 
}.. 
}// 
}00 ı
xC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\Extensions.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
{$ %
public 
static	 
class 

Extensions  
{! "
public 

static 
IServiceCollection $
AddInfrastructure% 6
(6 7
this7 ;
IServiceCollection< N
servicesO W
,W X
IConfigurationY g
configurationh u
)u v
{w x
services 
. 
AddApplication 
( 
) 
;  
services 
. 

AddMediatR 
( 
Assembly "
." # 
GetExecutingAssembly# 7
(7 8
)8 9
)9 :
;: ;
var 	
connectionString
 
= 
configuration *
.* +
GetConnectionString+ >
(> ?
$str? [
)[ \
;\ ]
services 
. 
AddDbContext 
< 
ReadDbContext )
>) *
(* +
context+ 2
=>3 5
context6 =
.= >
UseSqlServer> J
(J K
connectionStringK [
)[ \
)\ ]
;] ^
services 
. 
AddDbContext 
< 
WriteDbContext *
>* +
(+ ,
context, 3
=>4 6
context7 >
.> ?
UseSqlServer? K
(K L
connectionStringL \
)\ ]
)] ^
;^ _
services 
. 
	AddScoped 
< 
IAeronaveRepository ,
,, -
AeronaveRepository. @
>@ A
(A B
)B C
;C D
services   
.   
	AddScoped   
<   
IUnitOfWork   $
,  $ %

UnitOfWork  & 0
>  0 1
(  1 2
)  2 3
;  3 4
return"" 
services"" 
;"" 
}## 
}%% 
}&& Â
óC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\MemoryRepository\MemoryAeronaveRepository.cs
	namespace		 	
	Aeronaves		
 
.		 
Infraestructure		 #
.		# $
MemoryRepository		$ 4
{		5 6
public

 
class

	 $
MemoryAeronaveRepository

 '
:

( )
IAeronaveRepository

* =
{

> ?
private 
readonly 
MemoryDatabase #
	_database$ -
;- .
public 
$
MemoryAeronaveRepository #
(# $
MemoryDatabase$ 2
database3 ;
); <
{= >
	_database 
= 
database 
; 
} 
public 

Task 
CreateAsync 
( 
Aeronave $
obj% (
)( )
{* +
	_database 
. 
	Aeronaves 
. 
Add 
( 
obj !
)! "
;" #
return 
Task 
. 
CompletedTask 
;  
} 
public 

Task 
< 
Aeronave 
> 
FindByIdAsync '
(' (
Guid( ,
id- /
)/ 0
{1 2
return 
Task 
. 

FromResult 
( 
	_database &
.& '
	Aeronaves' 0
.0 1
FirstOrDefault1 ?
(? @
x@ A
=>B D
xE F
.F G
IdG I
==J L
idM O
)O P
)P Q
;Q R
} 
public 

Task 
< 
List 
< 
Aeronave 
> 
> 
GetAll  &
(& '
)' (
{) *
return 
Task 
. 

FromResult 
( 
	_database &
.& '
	Aeronaves' 0
.0 1
ToList1 7
(7 8
)8 9
)9 :
;: ;
} 
public 

Task 
UpdateAsync 
( 
Aeronave $
obj% (
)( )
{* +
return 
Task 
. 
CompletedTask 
;  
}   
}"" 
}## ∫
çC:\Users\Joseluis\Documents\GitHub\ms-Aeronave-ProyFinal_JY\ms-Aeronave-ProyFinal\Aeronave.Infraestructure\MemoryRepository\MemoryDatabase.cs
	namespace 	
	Aeronaves
 
. 
Infraestructure #
.# $
MemoryRepository$ 4
{5 6
public		 
class			 
MemoryDatabase		 
{		 
private

 
readonly

 
List

 
<

 
Aeronave

 "
>

" #

_aeronaves

$ .
;

. /
public 

List 
< 
Aeronave 
> 
	Aeronaves #
{$ %
get 	
{
 
return 

_aeronaves 
; 
}  
} 
public 

MemoryDatabase 
( 
) 
{ 

_aeronaves 
= 
new 
List 
< 
Aeronave $
>$ %
(% &
)& '
;' (
} 
} 
} 