const EventEmitter = require("events")

class Logger extends EventEmitter{
    
    log(message){
        console.log(message)
        this.emit('MessageLogger', {id:1, url: 'http://mylogger.io/log'})
    }

}

module.exports = Logger