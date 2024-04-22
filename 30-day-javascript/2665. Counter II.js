/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function(init) {
    
    class Counter{
        constructor(init){
            this.originInit = init;
            this.alteredInit = init;
        }
    
       increment(){
            return this.alteredInit+=1;
        }
    
        reset(){
            this.alteredInit = this.originInit
            return this.alteredInit;
        }
    
        decrement(){
            return this.alteredInit -=1 ;
        }
    
    
    }
    

    return new Counter(init);
};



/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */
