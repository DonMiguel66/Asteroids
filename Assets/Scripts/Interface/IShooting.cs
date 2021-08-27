using System;
using UnityEngine;

namespace Asteroids
{
    /// <summary>
    /// Комментарии для Вас, в объясняющих целях, как только сделаю задуманное -удалю :D
    /// Поля ShotSpeed, LifeTime и ShotForce - сделал на будущее, хочу потом разделить выстрелы на типы (ракета и снаряд)
    /// На санряд будет сила действовать, ракета будет наводящейся с конст. скоростью. 
    /// Потом так же переделаю управление и отображение камеры, просто в этой итерации не занимался. (Об этом вам так же в телеге написал)
    /// Спасибо за внимание! :D
    /// </summary>
    public interface IShooting
    {
        float ShotSpeed { get; }

        float ShotLifeTime { get; }

        float ShotForce { get; }
        void Shooting(GameObject _bullet, Transform _shootPoint);
    }
}
