            {
            }
            // git apply has problem with dealing with autocrlf
            // I noticed that patch applies when '\r' chars are removed from patch if autocrlf is set to true
            {
            }
            {
            }
            {
            }
            {
            }
            // if file is new, --- /dev/null has to be replaced by --- a/fileName
            {
            }
            {
            }

            string[] headerLines = header.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            {
                {
                }
            }
                {
                }
                {
                }
            string fileMode = "100000"; // given fake mode to satisfy patch format, git will override this

            {
            }
            {
            }

            {
            }

            // git apply has problem with dealing with autocrlf
            // I noticed that patch applies when '\r' chars are removed from patch if autocrlf is set to true
            {
            }
            {
            }
            {
            }

        // TODO encoding for each file in patch should be obtained separately from .gitattributes
            {
            }
                {
                }
            {
            }
                    {
                    }
                    {
                    }

                    {
                    }
                    {
                    }

            {
            }

            {
            }

            // stage no new line at the end only if last +- line is selected
            {
            }

            {
            }
        // patch base is changed file
            {
            }
                    {
                    }
                    {
                    }

            {
            }

            {
            }

            {
            }
            {
            }
        private int _StartLine;
        private List<SubChunk> _SubChunks = new List<SubChunk>();
                    _SubChunks.Add(_CurrentSubChunk);

            {
            }
            {
            }
            // if postContext is not empty @line comes from next SubChunk
            {
                _CurrentSubChunk = null; // start new SubChunk
            }
            {
            }
            {
            }
            return int.TryParse(header, out _StartLine);
            {
            }

                    // do not refactor, there are no break points condition in VS Experss
                    {
                    }
                    {
                    }
                        {
                        }
                        {
                        }
                    {
                    }
            result._StartLine = 0;
            {
            }
            {
            }
            {
            }

                // do not refactor, there are no breakpoints condition in VS Experss
                {
                }
                            // if the last line is selected to be reset and there is no new line at the end of file
                            // then we also have to remove the last not selected line in order to add it right again with the "No newline.." indicator

                {
                }

            foreach (SubChunk subChunk in _SubChunks)
            {
            }
            diff = "@@ -" + _StartLine + "," + removedCount + " +" + _StartLine + "," + addedCount + " @@".Combine("\n", diff);

            // When there is no patch, return nothing
            {
            }
            {
            }

                // if selection intersects with chunsk
                    {
                    }

            {
            }
            return result;