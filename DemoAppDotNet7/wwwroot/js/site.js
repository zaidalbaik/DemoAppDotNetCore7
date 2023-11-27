// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    //$("button").click(function () {
    //    $("p").fadeTo(2000, .3, function () { alert("Hi"); });
    //});

    //---------------------------------------------------

    //$("button").click(function () {
    //    $("p").fadeOut(2000, function () { alert("Hi"); });
    //});

    //---------------------------------------------------

    $(".loginDiv").animate({
        width: '400px',
        height: '400px',
        top: '150px',
        left: '3px',
    }, 1000);
    //---------------------------------------------------

    // get/set  functions =>  text() ,html(),val()
    var result = $("#contanerDiv");
    var writings = $("#writings");
    var result = $("#result");
    var btnShowWritings = $("#btnCheck");
    var googleLink = $("#GoogleLink");
    btnShowWritings.click(function () {

        result.text("You have Wrote :" + writings.val());

        btnShowWritings.attr("class", "btn btn-danger");
        googleLink.attr("href", "https://www.facebook.com");
        // or

        //change multi attributes

        //googleLink.attr({
        //    "class": "btn btn-danger",
        //    "href":"https://www.facebook.com",
        //});

        googleLink.text("Go to facebook"); // => change text for this item
    });
    //---------------------------------------------------

    var myItem = $(".divTest");
    myItem.append("<span><a style='color: Red;' href='https://www.Google.com'>Google</a></span>");

    myItem.prepend("<span><a href='https://www.facebook.com'>facebook</a></span>");

    myItem.before("<span><a style='color: Purple;' href='https://www.instagram.com/'>instagram</a></span>");

    myItem.after("<span><a style='color: Green;' href='https://web.whatsapp.com/'>whatsapp</a></span>");


    $("<p></p>", {
        text: "appendTo",
        class: "blabla",
    }).appendTo(".divTest");

    //for explanation
    //$("#blablaElement").prependTo(".BlablaotherElement");

    $("<p></p>", {
        text: "prependTo",
        class: "blabla2",
    }).prependTo(".divTest");

    //---------------------------------------------------
    var btnRemove = $("#btnRemove");
    var btnAddText = $("#btnAddText");
    var btnRemoveContains = $("#btnRemoveContains");
    var removeDiv = $("#removableDiv");

    btnRemove.click(function () {
        removeDiv.fadeOut(2000, function () {
            removeDiv.remove();
        });

        $("#divRemove").remove();

        $("#divEmpty").empty();
    });

    btnAddText.click(function () {
        $("#divEmpty").append("<p>New paragraph</p>");
    });

    btnRemoveContains.click(function () {
        $("p").remove(" :contains('sssssssssssssss')");
    });

    //---------------------------------------------------

    var btnChangeClass = $("#btnChangeClass");

    btnChangeClass.click(function () {
        $(".test ,.test2 ").addClass("bg-light mb-3 border border-dark border-dashed");
        $(".test1 ").addClass("bg-light mb-3 border border-success border-dashed rounded");
        $("#closebtn").addClass("test4").removeClass("close");;
    });

    //--------------------------------------------------
    ////some examples:

    $("#closebtn").click(function () {
        /*   $("html").empty();*/
        btnChangeClass.animate({
            width: '200px',
            height: '200px',

        }, 1000, function () {
            btnChangeClass.animate({
                width: '100px',
                height: '50px',

            }, 1000);
        });
    });

    //-----------------------------------------------------


    $("#btnpppp").click(function () {
        $("p:contains('love')").addClass("bg-danger text-white").fadeOut(1000).fadeIn(1000);
        $("p:first").addClass("bg-danger text-white").fadeOut(1000).fadeIn(1000); // => First p element
        $("p:last").addClass("bg-danger text-white").fadeOut(1000).fadeIn(1000); // => last p element
        $("p:eq(16)").addClass("bg-danger text-white").fadeOut(1000).fadeIn(1000); // => p element at 3 position

    });

    $("#btnToggleClass").click(function () {
        $(this).slideUp(10, function () {
            $(this).toggleClass("bg-danger text-black");
        }).slideDown(200);
    });


    //--------------------------------------------------------
    var btnTestCss = $("#btnTestCss");
    var testCssDiv = $("#testCssDiv");
    btnTestCss.click(function () {

        testCssDiv.css({
            "backgroundColor": "purple",
            "color": "yellow",
            "fontWeight": "bold"
        });

    });

    $("#btnTestDim").click(function () {
        //$("<span></span>").text("document width is : " + $(document).width() + "and dim element width is :" + $("#dim").width()).appendTo("body");
        //Set width ======>   $("#dimTest").width("-=" +40);

        //Get width
        var dimTestWidth = $("#dimTest").width();


        $("#dimTest").animate({
            width: dimTestWidth - 40,
        }, 300, function () {
            alert("document width is : " + $(document).width() + "and dim element width is :" + $("#dimTest").width());
        });

    });

    $("#childItem").click(function () {
        $(this).parent().css({
            "color": "red",
            "border": "10px solid #f00"
        });
    });


    sssitem = $("#sssitem");
    sssitem.click(function () {
        sssitem.prev().css("backgroundColor", "Green");
        sssitem.next().css("backgroundColor", "Green");
    });


    $(".testNot").not(":contains('a')").css("border", "2px dashed #f00");

    $(".testNot").filter(":contains('zz')").css("border", "2px dashed #0f0");

    $(".testNot").filter(function (a) {
        if (a % 2 != 0)
            return true;
    }).css("border", "2px dashed #00f");


    //handler event | mote : the parameter 2 in on() method is optinal but he using for select child for the elemnt that is selected

    //$("body").on("click", "#btnCheckOnHandlerEvents", function () {

    //    $(this).toggleClass("btn-danger");
    //});

    //hanler multi event
    //$("body").on("mouseenter mouseleave", "#btnCheckOnHandlerEvents", function () {

    //    $(this).toggleClass("btn-danger");
    //});


    //create custom event using trigger

    $("#btnCheckOnHandlerEvents").on("click", function () {
        $(this).hide();
    });

    //$("body").on("mouseenter","#TestCLickEevent", function () {
    //    $(this).children().css({
    //        backgroundColor: 'purple',
    //        color :'yellow'
    //    });
    //});
    // -----
    //$("#TestCLickEevent").on("myCustom", function (event ,myHeight,myWidth) {
    //    $(this).height(myHeight).width(myWidth);

    //});

    //$("#btnCustomEvent").click(function () {
    //   // $(this).hide();
    //    $("#TestCLickEevent").trigger("myCustom",["200px"],["400px"]);
    //});
    // ---

    $("#btnCustomEvent").click(function () {
        // $(this).hide();
        $("<p class='eee'><u>Click On Me</u></p>").insertAfter(this);
    });

    //must be the container for run this event for this p element becouse this element created by ather event 
    $("body").on("click", ".eee", function () {
        $(this).css("background-color", "red");
    });

    $("#TestOnMapMultiEvent").on({

        mouseenter: function () {
            $(this).text("mouse enter event");

        },
        click: function () {
            $(this).text("mouse Click event");

        },
        dblclick: function () {
            $(this).text("mouse double click event");

        },
        mouseleave: function () {
            $(this).text("mouse leave  event");

        },


    });

    //$('p').longpress(1000, function () //Replace 1000 with your desired milliseconds
    //{
    //    alert('I have been long pressed!');
    //});


    $("#googleLink").on("click", function (event) {
        event.preventDefault();
        if (event.isDefaultPrevented()) {

            $(this).text("This the link not work");
        } else {

            $(this).text("This link will take you to Google's website");
        }
    });


    $("input").on("keyup", function () {
        $("#TextKeyUpevent").text($(this).val());
    });
    //$("input").on("keydown", function (event) {
    //    alert("keydown");

    //});
    //$("input").on("keypress", function (event) {
    //    alert("press");
    //});

    $("select").on("change", function () {
        $("#carSelected").text("the car selected is: " + $(this).val());
    });

    //$("input").on("focus", function () {
    //    $(this).val("foucs");
    //});

    ////unfocus
    //$("input").on("blur", function () {
    //    $(this).val("blur");
    //});

    $("#oneEventDivsss").one("click", function () {
        $(this).css({
            fontSize: "+=3px",
        });
    });

    $("textarea").on("click", function () {
        $(this).select();// select the text inside this textarea element
    });

    $("textarea").on("select", function () {
        $(this).text($(this).text() + "Copied!");

    });
    //$("textarea").select(function () {
    //    alert("Copied !");
    //});

    $(window).on("resize", function () {

        var width = $(window).width();
        var height = $(window).height();
        console.log("width: " + width + "heigth: " + height);
    });

    $(window).on("scroll", function () {
        var sc = $(window).scrollTop();
        if (sc > 1000) {
            $("#testScrollDiv").fadeIn(100);
        } else {
            $("#testScrollDiv").fadeOut(100);
        }
    });

    $("#testScrollDiv").click(function () {
        console.log("ss");
    });

    //$("html").click(function (ev) {
    //    $(".circlezaid").show().offset({
    //        left: ev.pageX,
    //        top: ev.pageY
    //    });

    //});

    //$("html").on("mousemove mousewheel", function (ev) {
    //    $(".circlezaid").show().offset({
    //        left: ev.pageX,
    //        top: ev.pageY
    //    });

    //});

    $("#testScrollDiv").click(function () {
        $(window).scrollTop(0);
    });


    $("#formSubmit").submit(function (event) {
        if ($("#username").val() === "Confirm") {
            $("#validationText").text("Done Successfully").css("color", "red");
            return;
        }
        $("#validationText").text("please enter 'Confirm' word").css("color", "red");
        event.preventDefault();

    });


    //delay(1000) ==> for delaying
    //clone(true) ==> copy element and the events that spicialize for this element  /// clone(false) ==> copy element without events

    //remove ==> Delete element and remove events associated with it  ||  deatch ==> Delete element only without events

    //hasClass("any class") ==> return true,flase

    //offset() ==> get position x,y (top,left) =>حسب الصفحة كاملة

    //position => get position x,y (top,left) =>حسب الاب للعنصر

    //prop() => change property for any element ex:
    // $(".test").prop('disabled',true);
    // $(".test").prop('name','blalba');
    // change multi prop
    // $(".test").prop({
    //    'disabled':'disabled',
    //    'id' : 'test'
    //});
    //


    //replaceWith();
    //ex: $("div").replaceWith("<p>sss</p>");

    //scrollTop()

    //wrap();
    //each();

    //has(item || class|| id || another item);بطبق الحكي عأي اشي بطبق الاستعلام او الشرط

    //$("div").patent.is('span') ==> هل كذا او كذا

    /*
    $("div").parent().css("color,"red").end().children().css("color","blue").end()
    .css("border","3px solid #00f");
    */




    function testAPI() {

        var myRequest = new XMLHttpRequest();

        myRequest.onreadystatechange = function () {
            if (this.readyState === 4 && this.status == 200) {
                console.log(this.responseText);
                console.log(myRequest);
            }
        }

        //myRequest.open("GET", "https://localhost:7096/lib/jquery/dist/jquery.min.js", true);

        myRequest.open("GET", "https://jsoneditoronline.org/#left=local.voyise&right=local.yeqodi", true);


        myRequest.send();
    }

    $("#btnTestAPI").on("click", function () {
        testAPI();
    });



});


// Long Press example
//$.fn.longpress = function (time, onlongpress) {
//    var timestart = 0;
//    var timer = null;

//    //If time wasn't specified
//    if (!onlongpress) {
//        onlongpress = time;
//        time = 2000; //Default long-press time
//    }

//    //When the mouse is down start checking the time
//    $(this).on('mousedown', function (e) {
//        timestart = new Date().getTime();
//        checktime();
//    });

//    //Check to see how much time has passed
//    var checktime = function () {
//        if (new Date().getTime() >= (timestart + time)) {
//            if (typeof onlongpress == 'function') {
//                //Fire the callback
//                onlongpress();
//            }
//        }
//        else {
//            //Keep checking
//            timer = setTimeout(checktime, 1);
//        }
//    }

//    $(this).on('mouseleave mouseup', function (e) {
//        //Stop checking if the mouse is up too early or the mouse leaves the element
//        timestart = 0;
//        clearTimeout(timer);
//    });
//};




/*
Jquery explaination :



//--------------Explaination-----------------
 
jQuery : 

syntax : 

$  ==>  For write JQuery Code  
("Html Element"). AnyFuncitonForJQuery

ex:

  $("button").click(function () {
        $("p").hide();
    });

-------

Some Events :
Click(func) / Dblclick(func) / Mouseenter(func) / Mouseleave(func) / Hover(func,func)

-------

built in function for JQuery for Effects: 
(Effects)

this fuctions change on 'display' property in CSS 
hide();
show();
toggle();

---------
  
this fuctions change on 'opacity' property in CSS 
fadeIn(speed,callback funciton); ==> راجع الامثلة 
fadeOut();
fadeTo();
fadeToggle();

---------

SlideDown() => لازم يكون مخفي عشان يظهر
SlideUp() =>لازم يكون ظاهر عشان يختفي
SlideToggle() => شغال عالجهتين تبديل


---------
animate : 

animate({css prop} ,speed,callback funciton);

ex:
$(".loginDiv").animate({
width :'200px',
height: '400px'
},1000,function(){..etc any code});

---------
stop : 
stop(); => stop animation for any element 

stop(true) => stop all animation for element
stop(false ,true) => finish animation one by one 

stop(true,false) => run first animation only

ex: 
$("button").click(function(){
    $("divAnim").stop();
});
--------------
 // get/set  functions =>  text() ,html(),val()
 
ex:
 var result = $("#contanerDiv");
 var writings = $("#writings");
 var result = $("#result");
 var btnShowWritings = $("button");

 btnShowWritings.click(function () {

     result.text("You have Wrote :" + writings.val());
 });

attr(); ==> this function get all attribute for html elements
ex:
$("button").attr("class" ,"btn btn-danger");

  //change multi attributes 
//ex :
    //googleLink.attr({
    //    "class": "btn btn-danger",
    //    "href":"https://www.facebook.com",
    //});
--------------
 
Append() => ضع العنصر جوا العنصر المحدد ولكن في اخره
Prepend() => ضع العنصر جوا العنصر المحدد ولكن في اوله

Before() => ضع العنصر خارج العنصر المحدد لكن قبله
After() => ضعضع العنصر خارج العنصر المحدد لكن بعده

AppendTo() => يقوم بانشاء عنصر او ضع العنصر المحدد بعد العنصر الذي ستضعه بالاقواس
PrependTo() يقوم بانشاء عنصر او ضع العنصر المحدد قبل العنصر الذي ستضعه بالاقواس

----------------

Remove();  => يقوم بحذف العنصر وما بداخله
Empty();  => يقوم بحذف ما بداخل العنصر فقط


Remove(" :contains('any word') "); => يقوم بحذف العنصر الذي يحتوي على كلمة معينة
-----------------

change classes:  

- addClass(); ==> adding class with saving old class 

- removeClass(); ==> remove class as old class 

- toggleClass(); ==> add and remove class
   ex: adding class x for div element and when this function is called again will be remove      class x

ex:
  var btnChangeClass = $("#btnChangeClass");

  btnChangeClass.click(function () {
      $(".test ,.test2 ").addClass("bg-light mb-3 border border-dark border-dashed");
      $(".test1 ").addClass("bg-light mb-3 border border-success border-dashed rounded");
      $("#closebtn").addClass("test4").removeClass("close");
  });

in this ex: =>  $("#closebtn").addClass("test4").removeClass("close"); =>add new class and remove old class 

----
  $("p:contains('love')")   => select 'p' contains love word
  $("p:first")  	    => select first 'p' element in document
  $("p:last") 		    => select last 'p' element in document
  $("p:eq(16)") 	    => select the 'p' element at position 16 in the document

ex:
 $("#btnpppp").click(function () {
     $("p:contains('love')").addClass("bg-danger text-white").fadeOut(1000).fadeIn(1000);
     $("p:first").addClass("bg-danger text-white").fadeOut(1000).fadeIn(1000);  
     $("p:last").addClass("bg-danger text-white").fadeOut(1000).fadeIn(1000);  
     $("p:eq(16)").addClass("bg-danger text-white").fadeOut(1000).fadeIn(1000);  

 });
----
toggleClass: ex:
    $("#btnToggleClass").click(function () {
        $(this).slideUp(10, function () {
            $(this).toggleClass("bg-danger text-black");
        }).slideDown(200);
    });
------------------------------------
Change css code and change style using jquery

css();

ex:
   var btnTestCss = $("#btnTestCss");
   var testCssDiv = $("#testCssDiv");
   btnTestCss.click(function () {

       testCssDiv.css({
           "backgroundColor": "purple",
           "color": "yellow",
           "fontWeight": "bold"
       });

   });

--------------------------------------------------


 //width ==> will be get Width for elements without padding, border and margin

 //innerWidth ==> will be get Width for elements    with padding    without border and margin

 //outerWidth ==> will be get Width for elements with padding and border   but without  margin  Unless used width(true) => will be including margin

 width()
 innerWidth()
 outerWidth()

 height();
 innerHeight()
 outerHeight()

ex: for use width


    $("#btnTestDim").click(function () { 
        //Set width ======>   $("#dimTest").width("-=" +40);

        //Get width
        var dimTestWidth = $("#dimTest").width();


        $("#dimTest").animate({
            width: dimTestWidth - 40,
        }, 300, function () {
            alert("document width is : " + $(document).width() + "and dim element width is :" + $("#dimTest").width());
        });


    });

ex: get width or height include padding and border and margin 
$(".blabla").outerWidth(true);
$(".blabla").outerHeight(true);
--
ex: get width or height include padding and border only 
$(".blabla").outerWidth();
$(".blabla").outerHeight();
--
ex: get width or height include padding only
$(".blabla").innerWidth();
$(".blabla").innerHeight();
--
ex: get width or height only
$(".blabla").width();
$(".blabla").height();
--
ex: set width or height
$(".blabla").width(50); // unit by defualt is 'px'   
$(".blabla").height(50);
$(".blabla").width("200%");
$(".blabla").height("200%");
$(".blabla").width("20em");
$(".blabla").height("20em");
$(".blabla").width("200px");
$(".blabla").height("200px");
$(".blabla").width("200pc");
$(".blabla").height("200pc");
$(".blabla").width("+=" + 50);
$(".blabla").height("+=" + 50);
$(".blabla").width("-=" + 50);
$(".blabla").height("-=" + 50);
$("#dimTest").width("-=10em");
$("#dimTest").width("-=10%");
$("#dimTest").width("-=10px"); 
..etc
----------------------------------------------------------------
Traversing  : 

 parent() ==>بجيب الاب المباشر للعنصر المحدد
 parents() بجيب  كل الآباء  للعنصر المحدد 
 parents(".test") بجيب الاب المحدد بين الاقواس للعنصر المحدد
 parentsUntil() بجيب كل الآباء للعنصر المحدد ايضا يفضل تحديد شرط
 parentsUntil(".test") الفرق هنا بجيب كل الاباء لحد الاب المحدد بين الاقواس ولا يشمله
ex : 
$("#blabla").parent().css({
 "color":"Red",
 "border":"10px solid #F00"
});
------------------------------------------------------------------
Traversing  :

children(); => بجيبلك كل الابناء للعنصر المحدد يعني لو غيرت اللون للابناء سوف يتغير لكل الابناء
 ex:
$("#blabla").children().css("backgroundColor","red"); => for all childrens 
--
children(".test"); => فقط test هون راح يجيب الابناء الذين لديهم كلاس 
ex :
#blabla").children().css("backgroundColor","red");
--
find(); ==> راح تجيبو html بتجيبلك كل الجذور للعنصر المحدد يعني لو قلتلها جيبيلي عنصر الو كلاس معين لكل جذور العنصر
يعني هاي بتمشي عالابناء وعالاحفاد لحد اخر السلالة
ex: 
$("#blabla").Find(".test").css("backgroundColor","red"); =>   blabla من جذور الاب test هون راح يصير التغيير على اي جذر لديه كلاس

ex: 
$("#blabla").Find($("p:contains('facebook')")).css("backgroundColor","red");


---------------------------------------------------------------------

Traversing : 


siblings() ==> بتجيبلك كل الاخوة للعنصر المحدد

siblings(".test") ==> test بتجيبلك الاخوة اللي لديهم كلاس

next() ==>بجيبلك العنصر اللي بعد العنصر المحدد مباشرةً

next(".test") ==> بعد العنصر المحدد ليس العنصر التالي مباشرة  فقط قد يكون العنصر الذي بعد العنصر التالي للعنصر المحدد الخ test بجيبلك اول عنصر  اخ يحتوي على كلاس 

nextAll();  ==> بتجيبلك كل العناصر التالية للعنصر المحدد

nextAll(".test"); ==> test بتجيبلك كل العناصر اللي بعد العنصر الذي لديه كلاس

nextUntil(".test") ==> test بتجيبلك كل العناصر بعد العنصر المحدد لحد ما يوصل كلاس

prevAll() prevUntil(); ==> ولكن للي للعناصر اللي قبل العنصر المحدد وليس اللي بعدو next نفس مبدأ ال 


-------------------------------------------------------------------------

Traversing :  

 first() ==> بتجيبلك اول عنصر يمثل العنصر المحدد => without parameters
 last() ==> بتجيبلك اخر عنصر يمثل العنصر المحدد => without parameters
 eq()  ==> بتجيبلك عنصر يمثل العنصر المحدد مع موقع انت تحدده سواء الاول او الثالث او العاشر 
ex:
 eq(0) => اول عنصر 
 eq(1) => ثاني عنصر من فوق لتحت طبعاً
 eq(-1) => اول عنصر من الاخر للاول من تحت لفوق بالصفحة
--
filter()=> تقبل ك باراميتير => jquery selector , class  ,id, funciton, etc.. اذا ضل 

 $("div").filter(".test")=>  قم بعمل تحديد عليه وقم بما تريد عليه test لديه كلاس  div لكل عنصر 
--
ex : 
  $("div").filter(funciton(index){
    return index === 1;
  }).css("color","red");
 

قم بعمل تحديد عليه وقم بعمل فلترة لكل عنصر بحيث اذا كان يساوي 1 حسب المثال او لا اذا حقق الشرط خذه وطبق ما تريد عليه  div لكل عنصر 

--
 not() ===> بالزبط filter عكس ال

تقوم بجلب العناصر التي لا تساوي العنصر الذي قمت بتحديده وتقوم بالعمليات عليه مثل ديزاين جديد الخ not يعني الفلتر بجيبلك العنصر عشان تقوم بعمل ما تريد عليه او مجموعة عناصر ايضاُ لكن ال

ex : 
$("#blabla").not(":contains('JQuery')").css("color","red");
--------------------------------------------------------------------------

Selectors: 

$("*") ==> select all elements
---
$("div")  ==> select div element
---
$(".test")  ==> select elements that has .test class
---
$("#test")  ==> select elements that has .test id 
---
$("div:first") ==> equivelant div.first()  => select first element as div
---
$("div:last") =>  equivelant div.last()  => select last element as div
---
$("div:odd")  ==> select div elements that has index is odd num
---
$("div:even") ==> select div elements that has index is even num
---
$("div ,.test, #test ,p:odd") ==>  multi selecting ex: select builtin element and classes and ids;
---

Selectors part2:

:first and :last => ذكرناهم سابقاً
 
:first-child
:last-child
:first-of-type
:last-of-type
:nth-child(index)
:nth-of-type(index)
:nth-last-child(index)
:nth-last-of-type(index)
--

$("p:first-child") :
 هو ابن لأب  معين وهو اول ابنائه   p هذا الاستعلام يعني انه قم بجلب اي عنصر 
 ثلاث شروط : 
  - ابن للأب
  - اول ابناءه  (الزامي يجب ان يكون اكبر ابن واول يعني اذا كان اكبر ابن من نوع اخر لن يتم جلبه)
  - نوعه p =>حسب المثال 
---
$("p:last-child") => لكن العكس بالشقلوب first نفس ال
---
$("p:first-of-type"):
 هو ابن لأب  معين وهو اول ابنائه من نوعه   p هذا الاستعلام يعني انه قم بجلب اي عنصر 
 الشروط  :
   - ابن للأب
   - وسيتم جلبه ان وجد p فنحن هنا نقول بالمثال نحن نريد اول ابناءه من نوع  div اول ابناءه من نوعه يعني قد يكون اول ابن له او اكبر ابن هو من نوع
---
$("p:last-of-type"): same first-of-type  but from 'last' 
---
$("p:nth-child(2)")
p ثاني طفل ولديه اب " اجباري "  وهو من نوع 
--- 
$("p:nth-last-child(3)") : same nth-child(3) but from last 
---
$("p:nth-of-type(2)") 
p ولديه اب وليس اجباري ان يكون ترتيبه بين اخوته من الانواع المختلفة هو الثاني فقط ترتيبه يجب ان يكون الثاني بين اخوته من نوعه وهو p ثاني طفل من نوع
---
$("p:nth-last-of-type(2)") : same p:nth-of-type(2) but from last 
 
---
//////////// note:
script هو ال  html خذ بعين الاعتبار ان من ابناء عنصر ال childs ملاحظة مهمة عن التحدث عن ال
////////////
----
$("p:only-child")  => هو الابن الوحيد لابيه
$("p:only-of-child")  => هو الابن الفريد من نوعه لابيه بحيث قد يكون هناك انواهع اخرى

$("div > p") => direct child => div لديه اب مباشر هو p يعني كل 
div بداخل ال p ملاحظة هنا ليس المقصود انه لكل 
ul لكن ابوه على سبيل المثال هو  div داخل ال p لانه قد يكون 

$("div + p")  =>  element + nextElement  ==>p تاعو  next ال div يعني عنصر من نوع
  
$("h1 ~ p") => fetch all p elemet as a siblings for h1 to the same parent

$("eq(index)")  يساوي
$("gt(index)") اكبر من 
$("lt(index)") اقل من

 $("p:not()") ex :$("p:not( :contains('iii'))");

-----
 
Selectors part3:

$(":header")  => select all headers 
$(":animated") => apply changes on element animated
$(":focus")  => apply changes on element focused
 
$("div:contains") => apply changes on element contains any text

$("div:has('p')") => div inside it p

$(":empty")  => apply changes on element not contains any things

$(":parent ") =>apply changes on element has child or contains any things text,items,etc..

$(":hidden") => apply changes on elements display=none
 
$("div:visible") => apply changes on elements display=inline,block, ..etc

$(":root")  ==> html element
 
$("p:lang('en')") => the lang is attribute in html language
apply changes on element the attribute lang for it is 'en' or 'ar' or any language .
 
 
--------------------------------------------------
selectors part4 for attributes: 
$("[src]") 

$("[alt='image2']") 

$("[alt*='image2']") ===>   '*=' contains

$("[alt~='image2']") ===>   '~=' contains 'word' يعني فقط الكلمة كاملة بدون تقطيع

$("[alt~='image2']") ===>   '^=' start with..
   
 not equal: 
$("p[lang!='ar']") = p element has lang attribute and the value for this attribute is not equal 'ar'


----------

selectors part5:

$(":input")

select types of input
$("text")
$("password")
$("file")
$("image")
$("submit")
$("reset")
$("checkbox")
$("redio")


$(":checked") => fetch item has 'checked' attribute

$(":selected") =>fetch item has 'selected' attribute

$(":disabled") =>fetch item has 'disabled' attribute

$(":enabled") =>fetch item has 'enabled' attribute


note: 
If you want to hide or fade the item, it will not be hidden successfully

-----

ex : 
Console.log($(":selected").val()); used to <select> element 

---------

examples code:

    $("#btnToggleClass").click(function () {
        $(this).slideUp(10, function () {
            $(this).toggleClass("bg-danger text-black");
        }).slideDown(200);
    });


    //--------------------------------------------------------
    var btnTestCss = $("#btnTestCss");
    var testCssDiv = $("#testCssDiv");
    btnTestCss.click(function () {

        testCssDiv.css({
            "backgroundColor": "purple",
            "color": "yellow",
            "fontWeight": "bold"
        });

    });

    $("#btnTestDim").click(function () {
        //$("<span></span>").text("document width is : " + $(document).width() + "and dim element width is :" + $("#dim").width()).appendTo("body");
        //Set width ======>   $("#dimTest").width("-=" +40);

        //Get width
        var dimTestWidth = $("#dimTest").width();


        $("#dimTest").animate({
            width: dimTestWidth - 40,
        }, 300, function () {
            alert("document width is : " + $(document).width() + "and dim element width is :" + $("#dimTest").width());
        });

    });

    $("#childItem").click(function () {
        $(this).parent().css({
            "color": "red",
            "border": "10px solid #f00"
        });
    });


    sssitem = $("#sssitem");
    sssitem.click(function () {
        sssitem.prev().css("backgroundColor", "Green");
        sssitem.next().css("backgroundColor", "Green");
    });


    $(".testNot").not(":contains('a')").css("border", "2px dashed #f00");

    $(".testNot").filter(":contains('zz')").css("border", "2px dashed #0f0");

    $(".testNot").filter(function (a) {
        if (a % 2 != 0)
            return true;
    }).css("border", "2px dashed #00f");


    //handler event | mote : the parameter 2 in on() method is optinal but he using for select child for the elemnt that is selected

    //$("body").on("click", "#btnCheckOnHandlerEvents", function () {

    //    $(this).toggleClass("btn-danger");
    //});

    //hanler multi event
    //$("body").on("mouseenter mouseleave", "#btnCheckOnHandlerEvents", function () {

    //    $(this).toggleClass("btn-danger");
    //});


    //create custom event using trigger

    $("#btnCheckOnHandlerEvents").on("click", function () {
        $(this).hide();
    });

    //$("body").on("mouseenter","#TestCLickEevent", function () {
    //    $(this).children().css({
    //        backgroundColor: 'purple',
    //        color :'yellow'
    //    });
    //});
    // -----
    //$("#TestCLickEevent").on("myCustom", function (event ,myHeight,myWidth) {
    //    $(this).height(myHeight).width(myWidth);

    //});

    //$("#btnCustomEvent").click(function () {
    //   // $(this).hide();
    //    $("#TestCLickEevent").trigger("myCustom",["200px"],["400px"]);
    //});
    // ---

    $("#btnCustomEvent").click(function () {
        // $(this).hide();
        $("<p class='eee'><u>Click On Me</u></p>").insertAfter(this);
    });

    //must be the container for run this event for this p element becouse this element created by ather event 
    $("body").on("click", ".eee", function () {
        $(this).css("background-color", "red");
    });

    $("#TestOnMapMultiEvent").on({

        mouseenter: function () {
            $(this).text("mouse enter event");

        },
        click: function () {
            $(this).text("mouse Click event");

        },
        dblclick: function () {
            $(this).text("mouse double click event");

        },
        mouseleave: function () {
            $(this).text("mouse leave  event");

        },

      
    });

    //$('p').longpress(1000, function () //Replace 1000 with your desired milliseconds
    //{
    //    alert('I have been long pressed!');
    //});


    $("#googleLink").on("click", function (event) {
        event.preventDefault();
        if (event.isDefaultPrevented()) {

            $(this).text("This the link not work");
        } else {

            $(this).text("This link will take you to Google's website");
        } 
    });

 
    $("input").on("keyup", function () {
        $("#TextKeyUpevent").text($(this).val());
    });
    //$("input").on("keydown", function (event) {
    //    alert("keydown");

    //});
    //$("input").on("keypress", function (event) {
    //    alert("press");
    //});

    $("select").on("change", function () {
        $("#carSelected").text("the car selected is: " + $(this).val());
    });
     

*/