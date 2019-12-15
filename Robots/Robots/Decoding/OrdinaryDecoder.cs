namespace Robots.Robots.Decoding
{
    class OrdinaryDecoder : DecoderSkill
    {
        public override bool IsDecodingSuccessful()
        {
            return Randomizer.GenerateChance(60);
        }
    }
}
