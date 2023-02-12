class DNA {
    public string Seq;

    public DNA(string seqSet) {
        Seq = seqSet;
    }

    public DNA Replicate1() {
        return new DNA(Seq);
    }

    public DNA Replicate2() {
        return this;
    }

    public void Mutate(string seqSet) {
        Seq = seqSet;
    }
}