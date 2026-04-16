const express = require("express")
const cors = require(cors)
const router = require('./router')
const server = express()
const dbHandler = require("./dbHandler.js")
require("dotenv").config()

server.use(cors)
server.use(router)
server.use(express.json())
server.use(dbHandler)

server.listen(3000, console.log("online"))