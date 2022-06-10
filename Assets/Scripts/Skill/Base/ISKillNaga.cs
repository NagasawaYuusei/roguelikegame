interface ISkillNaga
{
    SkillDef SkillId { get; }
    void Setup();
    void Update();
    void Levelup();
}

public enum SkillDefNaga
{
    ShotBullet = 0,
    AreaAttack = 1,
}
