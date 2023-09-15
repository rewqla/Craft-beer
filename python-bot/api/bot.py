from aiogram import Bot, Dispatcher, types

TOKEN = '5680096668:AAHuis7pyG-G4G0taF7WeumTRdU-jgGUeY0'

bot = Bot(token=TOKEN)
dp = Dispatcher(bot=bot)


@dp.message_handler(commands=['start'])
async def start_handler(message: types.Message):
    await message.reply(f"Hello")

