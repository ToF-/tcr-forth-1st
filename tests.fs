require ffl/tst.fs

: pass-or-die
  tst-errors @ if
    tst-errors ? ." failures" cr
    s" failed" exception throw
  then ;

t{ ." a dummy test" cr
  true ?false
}t

pass-or-die
bye
