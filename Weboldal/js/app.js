 var btn=document.querySelector(".btn-2");
 var position;
 btn.addEventListener("mouseover",function(){
     position?(position=0):(position=150);
     btn.style.transform=`translate(${position}px,0px)`
     btn.style.transition="all 0.3s ease";
 })