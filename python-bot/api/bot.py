from aiogram import Bot, Dispatcher, types

from api.utils.utils import get_beer_data, get_order_data, get_user_order_data

TOKEN = '5680096668:AAHuis7pyG-G4G0taF7WeumTRdU-jgGUeY0'

bot = Bot(token=TOKEN)
dp = Dispatcher(bot=bot)


@dp.message_handler(commands=['start'])
async def start_handler(message: types.Message):
    await message.reply(f"Hello")


@dp.message_handler(commands=['beers'])
async def beer_info_answer(message: types.Message):
    beer_data = get_beer_data()

    if isinstance(beer_data, str):
        await message.reply(f"Помилка бази даних: {beer_data}")
    else:
        response_text = ""
        for beer in beer_data:
            response_text += f"ID: {beer[0]} \n Name: {beer[1]}, \n Description: {beer[2]} \n Price: {beer[3]} \n Volume: {beer[5]} \n Abv: {beer[6]} \n Raiting: {beer[7]}\n\n"

        await message.reply(response_text)


@dp.message_handler(commands=['orderByCode'])
async def order_info_answer(message: types.Message):
    unique_code = message.text.partition(" ")[2]
    order_data = get_order_data(unique_code)
    if isinstance(order_data, str):
        await message.reply(f"Помилка бази даних: {order_data}")
    else:
        response_text = ""
        for order in order_data:
            response_text += f"ID: {order[0]} \n Unique Code: {order[1]}, \n Date: {order[2]} \n Status: {order[3]} \n Name: {order[4]} \n Surname: {order[5]} \n Phone: {order[6]} \n City: {order[7]} \n Delivery: {order[8]}\n\n"

        await message.reply(response_text)


@dp.message_handler(commands=['orders'])
async def order_user_info_answer(message: types.Message):
    unique_code = message.text.partition(" ")[2]
    order_data = get_user_order_data(unique_code)
    if isinstance(order_data, str):
        await message.reply(f"Помилка бази даних: {order_data}")
    else:
        response_text = ""
        for order in order_data:
            response_text += f"ID: {order[0]} \n Unique Code: {order[1]}, \n Date: {order[2]} \n Status: {order[3]} \n Name: {order[4]} \n Surname: {order[5]} \n Phone: {order[6]} \n City: {order[7]} \n Delivery: {order[8]}\n\n"

        await message.reply(response_text)


@dp.message_handler(commands=['about'])
async def about_answer(message: types.Message):
    response_text = "Я виріс у Шарлотті, штат Північна Кароліна, і мені пощастило, що в моєму районі були " \
                    "макарони та провіант. У дитинстві я був вражений тим, що, коли ти зупинявся, " \
                    "ти завжди бачив, як люди щось виготовляють. Це не була їжа, виготовлена машинами на сірій " \
                    "фабриці десь далеко. Це було зроблено з великою гордістю людьми з мого району. Я переїхав до " \
                    "Буна, щоб навчатися в штаті Аппалачі, і почав працювати в компанії Stick Boy Bread. Я " \
                    "помітив багато з тих самих речей, які я бачив у Pasta & Provisions — ту саму відданість " \
                    "якості, від інгредієнтів до методів і до рівня персоналу. Здавалося логічним, що місто, " \
                    "яке любить випічку та чудовий хліб, може скористатися макаронним магазином! Далі були " \
                    "сендвічі, крафтове пиво та гарне вино. Я думав, що все готово... доки не звільнилося місце " \
                    "поруч із нами. Випадкова згадка двом друзям, які думали відкрити пивоварню, призвела до " \
                    "того, що ми стали дегустаційним залом компанії Booneshine Brewing Company. 1 липня 2015 року " \
                    "ми розлили першу пінту Booneshine IPA! Відтоді Booneshine переїхав у набагато більший " \
                    "простір, потребуючи більше місця для виробництва свіжого крафтового пива." \
                    "" \
                    "Як і Pasta & Provisions і Stick Boy, ми завжди використовуватимемо якісні інгредієнти та " \
                    "готуватимемо з нуля. Ми завжди будемо шукати вина, які добре виготовлені та пропонують " \
                    "відчуття місця. Наше пиво та сидр будуть свіжими та цікавими." \
                    "" \
                    "Я пишаюся тим, ким ми стали, і вдячний спільноті, яка прийняла нас і надала відгук. " \
                    "Сподіваємось, ви приєднаєтесь до нас, вип’єте пінту, перекусите трохи та повезете вечерю " \
                    "додому." \
                    "-Патрік Салліван, власник"

    await message.reply(response_text)


@dp.message_handler(commands=['help'])
async def help_answer(message: types.Message):
    response_text = "Commands: \n !about - history about our beer \n !beers - catalog of beer \n !orders [phone] " \
                    "- all yours orders \n !orderByCode [code] - Find order informations by code"

    await message.reply(response_text)
