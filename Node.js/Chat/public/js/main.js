const chatForm = document.getElementById("chat-form")

const socket = io()

socket.on('message', (data) => {
    addMessage(data)
})

chatForm.addEventListener('submit', (e) => {
    e.preventDefault()
    const message = e.target.elements.msg.value
    socket.emit('chatMessage', message)
})

const addMessage = (message) => {
    const div = document.createElement('div')
    div.classList.add('message')
    div.innerHTML = `<p class="meta">سیاوش <span>9:15pm</span></p>
          <p class="text">
            ${message}
          </p>`;

    document.querySelector('.chat-messages').appendChild(div)
}