namespace Robots.Robots.Decoding
{
    class BadDecoder : DecoderSkill
    {
        public override bool IsDecodingSuccessful()
        {
            return Randomizer.GenerateChance(10);
        }
    }
}
