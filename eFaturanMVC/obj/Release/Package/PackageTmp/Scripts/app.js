function splitScrool(){
 const controller = new ScrollMagic.Controller();
 
 new ScrollMagic.Scene({
     duration: '200%',
     triggerElement: '.hakkinda-title',
     triggerHook: 0
 })
 .setPin('.hakkinda-title')
 .addIndicators()
 .addTo(controller);
}

splitScrool();