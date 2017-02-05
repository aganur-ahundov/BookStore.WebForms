﻿using System;
using System.Data.Entity;

namespace BookStore.Models.DbRepository
{
    //
    //class for db auto-initialization
    //

    public class DbInitialializer : DropCreateDatabaseAlways<BookContext>
    {

        protected override void Seed(BookContext context)
        {
            //context.Books.Add( new Book("Книжный вор", "Маркус Зузак", "Роман", 250));
            //context.Books.Add( new Book("Множественные умы Билли Миллигана", "Дэниел Киз", "Биография", 200));
            //context.Books.Add(new Book("Ведьмак", "Анджей Сопковский", "Фентези", 150));
            //context.Books.Add(new Book("Превращение", "Франц Кафка", "Рассказы", 100));
            //context.Books.Add(new Book("Гарри Поттер", "Джоан Роулинг", "Фентези", 230));
            //context.Books.Add(new Book("Марсианские хроники", "Рей Брэдбери", "Рассказы", 130));
           // context.Books.Add(new Book("Записки о Шерлоке Холмсе", "Конан Дойл", "Рассказы", 120));
            //Перу английского писателя, публициста и журналиста Артура Конан Дойла принадлежат исторические, приключенческие, фантастические романы и труды по спиритизму, но в мировую литературу он вошел как создатель самого Великого Сыщика всех времен и народов - Шерлока Холмса.Благородный и бесстрашный борец со Злом, обладатель острого ума и необыкновенной наблюдательности, с помощью своего знаменитого дедуктивного метода сыщик решает самые запутанные головоломки, зачастую спасая этим человеческие жизни.Он гениально перевоплощается, обладает актерским даром и умеет поставить эффектную точку в конце каждого блестяще проведенного им расследования.

            //context.Books.Add(new Book("Мальчик в полосатой пижаме", "Джон Бойн", "Роман", 230));
            //Не так-то просто рассказать в двух словах об этой удивительной книге.Обычно аннотация дает читателю понять, о чем пойдет речь, но в данном случае мы опасаемся, что любые предварительные выводы или подсказки только помешают ему.Нам представляется очень важным, чтобы вы начали читать, не ведая, что вас ждет. Скажем лишь, что вас ждет необычное и завораживающее путешествие вместе с девятилетним мальчиком по имени Бруно.Вот только сразу предупреждаем, что книга эта никак не предназначена для детей девятилетнего возраста, напротив, это очень взрослая книга, обращенная к людям, которые знают, что такое колючая проволока. Именно колючая проволока вырастет на вашем с Бруно пути.Такого рода ограждения достаточно распространены в нашем мире. И нам остается только надеяться, что вы лично в реальной жизни не столкнетесь ни с чем подобным. Книга же наверняка захватит вас и вряд ли скоро отпустит. 

            //context.Books.Add(new Book("Маленький принц", "Антуан де Сент-Экзюпери", "Сказки", 90));
            //context.Books.Add(new Book("Мальчик по имени Рождество", "Мэтт Хейг", "Сказки", 70));
            //Вы держите в руках настоящую историю Отца Рождество. Возможно, вам он известен под другими именами -Дед Мороз, Санта - Клаус, Юль Томтен или Странный толстяк с белой бородой, который разговаривает с оленями и дарит подарки. Но так его звали не всегда. Когда - то в Финляндии жил мальчик по имени Николас.Хоть судьба обошлась с ним неласково, Николас всем сердцем верил в чудеса.И когда его отец пропал в экспедиции за полярным кругом, мальчик не отчаялся и отправился его искать. Николас и вообразить не мог, что там, за завесой северного сияния, его ждёт встреча с эльфами, троллями‚ проказливыми пикси и волшебством. Посреди бескрайних снегов ему предстоит поверить, что на свете не существует ничего невозможного. 


            base.Seed(context);
        }
    }
}