interface ISkill
{
    SkillDef SkillId { get; }
    void Setup();
    void Update();
    void Levelup();
}

public enum SkillDef
{
    ShotBullet = 0,
    AreaAttack = 1,
}
