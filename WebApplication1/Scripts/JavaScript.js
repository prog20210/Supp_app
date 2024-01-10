
// <script src="/path/to/script.js"></script>

const { Client } = require("pg")
const dotenv = require("dotenv")
dotenv.config()

const connectDb = async () => {
    try {
        const client = new Client({
            user: postgres,
            host: 127.0.0.1,
            database: sup,
            password: 12345,
            port: 5433
        })

        await client.connect()
        const res = await client.query('SELECT * FROM some_table')
        console.log(res)
        await client.end()
    } catch (error) {
        console.log(error)
    }
}

connectDb()
