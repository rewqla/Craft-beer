from aiogram import Bot, Dispatcher, types

from api.app import app
from api.models.CraftBeer import CraftBeer

TOKEN = '5680096668:AAHuis7pyG-G4G0taF7WeumTRdU-jgGUeY0'

bot = Bot(token=TOKEN)
dp = Dispatcher(bot=bot)


@dp.message_handler(commands=['start'])
async def start_handler(message: types.Message):
    await message.reply(f"Hello")


@app.message_handler(commands=['beers'])
async def beer_info_answer(message: types.Message):
    with app.app_context():
        beers = CraftBeer.query.all()

        beer_info = ""
        for beer in beers:
            beer_info += f"ID: {beer.id}\nName: {beer.name}\nDescription: {beer.description}\nPrice: {beer.price}\n\n"

        await message.reply(beer_info)