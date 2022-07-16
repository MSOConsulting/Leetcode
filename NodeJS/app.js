const Logger = require('./logger')
const logger = new Logger()

//Register a listener
logger.on('MessageLogger', (arg)=>{
    console.log(`Listener called for id: ${arg.id} and url: ${arg.url} `)
})

let message = 'Hello World'
logger.log(message)
