import {send, read} from './internal/index.js'
// import {send} from './internal/request.js'
// import {read} from './internal/response.js'

const sendRequest = (url, data)=>{
    send(url, data)
    return read()
}

console.log(sendRequest("https://Google.com", "hello"))