const express = require('express')
const http = require('http')
const path = require('path')
const socket = require('socket.io')

const PORT = process.env.PORT || 3000

const app = express()
const server = http.createServer(app)
const io = socket(server)

app.use(express.static(path.join(__dirname, 'public')))

io.on('connection', (socket) => {
    console.log('someone connected!')

    socket.emit('message', "Welcome to my chat!")

    socket.broadcast.emit('message', "A user joined to chat")

    socket.on('disconnect', () => {
        io.emit('message', "A user disconnected")
    })

    socket.on('chatMessage', (message) => {
        io.emit('message', message)
    })
})

server.listen(PORT, () => {
    console.log('listening on port ' + PORT)
})